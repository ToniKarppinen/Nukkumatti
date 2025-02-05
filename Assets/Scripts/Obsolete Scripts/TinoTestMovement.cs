using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TinoTestMovement : MonoBehaviour
{

    [SerializeField]
    private float movementSpeed;

    [SerializeField]
    private float jumpForce;

    [SerializeField]
    private Rigidbody2D playerRb;

    [SerializeField]
    private LayerMask jumpableLayer;

    [SerializeField]
    private Transform groundCheck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        Jump();
    }

    private void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector2 direction = new Vector2(horizontalInput, 0);

        transform.Translate(direction * movementSpeed * Time.deltaTime);
    }

    private void Jump()
    {

        if (IsGrounded())
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }
    }

    bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.4f, jumpableLayer);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyHead"))
        {
            Debug.Log("Enemy dead");
        } else if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("OUCH!");
        }
    }
}
