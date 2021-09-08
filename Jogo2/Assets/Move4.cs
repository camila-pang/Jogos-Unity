using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move4 : MonoBehaviour
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
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate((Vector2.right * Time.deltaTime * speed), Space.Self);
        }else if(Input.GetKey(KeyCode.A))
        {
            transform.Translate((Vector2.left * Time.deltaTime * speed), Space.World);
        }
    }
    private void FixedUpdate() 
    {
        

    
    }
}