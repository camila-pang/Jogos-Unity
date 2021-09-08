using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GroundType{
    None, 
    Soft, 
    Hard
}
public class Player : MonoBehaviour
{   
    [Header("Ground Properties")]
    public LayerMask groundLayer;
    public float groundDistance;
    public bool isGrounded;
    public Vector3[] footOffset;

    
    private Rigidbody2D rb2d;
    private Vector2 movement;
    private float xVelocity;

    [Header("Movement Properties")]
    public float jumpForce = 2f;
    public float speed = 2.5f;

    private int direction = 1;
    private float originalXScale;

    softGround = LayerMask.GetMask("Ground");
    hardGround = LayerMask.GetMask("GroundHard");
    col = GetComponent<Collider2D>();
    weapon = GetComponentInChildren<Weapon>();


    [Header("Audio")]
    [SerializeField] AudioCharacter audioPlayer = null;

    RaycastHit2D leftCheck;
    RaycastHit2D rightCheck;

    private Weapon weapon;

    private bool isJump;
    private Animator animator;
    private boll isFire;

    private LayerMask softGround;
    private LayerMask hardGround;
    private GroundType groundType;
    private Collider2D col; 

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        originalXScale = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(isFire == false)
        {
        float horizontal = Input.GetAxisRaw("Horizontal");
        movement = new Vector2(horizontal, 0);

        if(xVelocity * direction < 0f)
        {
            Flip();
        }

    }

        PhysicsCheck();

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            
        }

       
        if(Input.GetButtonDown("Fire1") && isFire == false && isGrounded)
        {
            movement = Vector2.zero;
            rb.velocity = Vector2.zero;
            animator.SetTrigger("fire");
        }
    }
     private void FixedUpdate() {
        if(!isFire)
        {
         xVelocity = movement.x * speed;
         rb2d.velocity = new Vector2(xVelocity, rb2d.velocity.y);
        }
    }

     private void LateUpdate() {
        animator.SetFloat("xVelocity", Mathf.Abs(xVelocity));
        animator.SetBool("isGrounded", isGrounded);
        animator.SetFloat("yVelocity", rb.velocity.y);

        animator.GetCurrentAnimator(0).IsTag("fire")
        {
            isFire = true;
        }else{
            isFire = false;
        }

        UpdateGround();


    }

    private void Flip()
    {
        direction *= -1;
        Vector3 scale = transform.localScale;
        scale.x = originalXScale * direction;
        transform.localScale = scale;
    }

    private void PhysicsCheck()
    {
        isGrounded = false;
        leftCheck = Raycast(new Vector2(footOffset[0].x, footOffset[0].y), Vector2.down, groundDistance,groundLayer);
        rightCheck = Raycast(new Vector2(footOffset[1].x, footOffset[0].y), Vector2.down, groundDistance,groundLayer);

        if(leftCheck || rightCheck) isGrounded = true;
    }

    private RaycastHit2D Raycast(Vector3 origin, Vector2 rayDirection, float length, LayerMask mask){
        
        Vector3 pos = transform.position;

        RaycastHit2D hit = Physics2D.Raycast(pos + origin, rayDirection, length, mask);

        //se quisermos mostrar o raycast em cena
        Color color = hit ? Color.red : Color.green;

    Debug.DrawRay(pos + origin, rayDirection * length, color);

        return hit;
    }

    private vois UpdateGround()
    {
        if(col.IsTouchingLayers(softGround))
            groundType = GroundType.Soft;
        else if (col.IsTouchingLayers(hardGround))
            groundType = GroundType.Hard;
        else 
            groundType = GroundType.None;
    }
}
