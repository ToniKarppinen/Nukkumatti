using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovementKarpo : MonoBehaviour
{
    private float horizontal;
    public float speed = 8f;
    public float jumpingPower = 16f;
    private bool isfacingRight = true;

    private bool doubleJump;  

    public Rigidbody2D rb;
    public Transform groundcheck;
    public LayerMask groundlayer;

    private Animator animator;

    [SerializeField] 
    private AudioSource jumpSoundEffect;

    private void Awake()
    {
        
    }
    private void Start()
    {
        animator = GetComponent<Animator>();
        
    }



    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        
        if (IsGrounded() && !Input.GetButton("Jump"))
        {
            doubleJump = false;
            animator.SetBool("isJumping", false);
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (IsGrounded() || doubleJump)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpingPower);

                doubleJump = !doubleJump;

                jumpSoundEffect.Play();

                animator.SetBool("isJumping", true);
                animator.Play("Player_Jump");

            }

        }
        
         
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)

        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
            animator.SetBool("isJumping", true);
        }

        Flip();
    }
    private void FixedUpdate () 
    { 
    rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);



        if (Mathf.Abs(rb.velocity.x) > 0.1f)
        {
            animator.SetBool("isRunning", true && IsGrounded()) ;
        }
        else
        {
            animator.SetBool("isRunning", false);
        }


    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundcheck.position, 0.2f, groundlayer);

    }

    private void Flip()
    { 
       if (isfacingRight && horizontal < 0f || !isfacingRight && horizontal > 0f)
        { 
          isfacingRight = !isfacingRight;
          Vector3 localscale = transform.localScale;
            localscale.x *= -1f;
            transform.localScale = localscale;

        }
    }
}
