using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Black : MonoBehaviour
{

    public float Speed = 0f;
    private float move = 0f;
    //bool facingRight = true;

    bool grounded;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float JumpForce = 700;

    bool doubleJump = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += Vector3.left * Time.deltaTime * 4;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += Vector3.right * Time.deltaTime * 4;
        }
        if ((grounded || !doubleJump) && Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, JumpForce));

            if (!doubleJump && !grounded)
                doubleJump = true;
        }

        
    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
    
        if (grounded)
            doubleJump = false;

        if (!grounded) return;

        move = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * Speed, GetComponent<Rigidbody2D>().velocity.y);
        /*
        if (move > 0 && !facingRight)
        {
            Flip();
        }
        else if (move < 0 && facingRight)
        {
            Flip();
        }
        */
    }
/*
    void Flip()
    {
        facingRight = !facingRight;
        Vector2 Scale = transform.localScale;
        Scale.x += -1;
        transform.localScale = Scale;
    }*/
}
