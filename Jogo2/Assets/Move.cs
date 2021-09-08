using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 4f;
    public bool isChao;

    public bool isJumping;
    

    public int nJump = 2;
    private float jumpSpeed = 4f;
    public float counterJump = 0.5f;

   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

     

        if(Input.GetButtonDown("Jump") && isChao)
        {
            isJumping = true;
        }
        if(Input.GetButton("Jump"))
        {
            counterJump -= Time.deltaTime;
        }
        if(Input.GetButtonUp("Jump"))
        {
            isJumping = false;
            counterJump = 0.5f;
        }
      


/*
    if(isChao)
    {
         nJump = 2;
        if(Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }else{
        if(Input.GetButtonDown("Jump") && nJump > 0)
        {
            nJump--;
            Jump();
        }
    }*/
    private void FixedUpdate() 
    {
        if(Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, 0);
        }else if(Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, 0);
        }else{
            rb.velocity = new Vector2(0, 0);
        }

        if(isJumping)
        {
            if(counterJump > 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);

                if(isChao == false) {
                    isJumping = false;

                    
                }
            }else{
                isJumping = false;
            }
        }

    
    }
    void Jump()
    {
        //rb.AddForce (new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
        rb.velocity = Vector2.up * jumpSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)  
    {
        if(collision.gameObject.tag == "chao")
        {
            isChao = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "chao")
        {
            isChao = false;
        }
    }
}