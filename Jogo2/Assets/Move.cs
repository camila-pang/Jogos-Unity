using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
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
            rb.velocity = new Vector2(speed, 0);
        }else if(Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, 0);
        }else{
            rb.velocity = new Vector2(0, 0);
        }

    
    }
}