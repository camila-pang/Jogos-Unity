using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate() 
    {
        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(speed, 0), ForceMode2D.Force);
        }else if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-speed, 0), ForceMode2D.Force);
        }

    
    }
}