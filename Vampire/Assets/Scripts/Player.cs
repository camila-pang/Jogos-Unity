using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{   
    
    public float speed = 2.5f;
    public float JumpForce;

   // public int health;
   // public bool invunerable;

    public bool isJumping;
    public bool doubleJump;

    private Rigidbody2D rig;
    private Animator anim;
    private SpriteRenderer sprite;


    //public Transform bulletSpawn;
    //public GameObject bulletObject;
   // public float fireRate;
   // public float nextFire;
    public bool isAlive;

    
    
    
    private Vector3 movement;


    
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer> ();
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();

       /* if(Input.GetButton("Fire1") && Time.time > nextFire) 
        {
            Fire();
        }*/

        
    }
   
    void Move(){
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;

       
        if(Input.GetAxis("Horizontal") > 0.01f)
        {
        
            anim.SetBool("run", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if(Input.GetAxis("Horizontal") < 0.01f)
        {
            anim.SetBool("run", true);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }

        if(Input.GetAxis("Horizontal") == 0f)
        {
            anim.SetBool("run", false);
        }
        
    }

    void Jump()
    {
        //if(Input.GetButtonDown("Jump") && !isJumping)-->ideal para pular somente uma vez
        if(Input.GetButtonDown("Jump"))
        {
            if(!isJumping)
            {
                rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                doubleJump = true;
                anim.SetBool("jump", true);
            }else
            {
                if(doubleJump)
                {
                     rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                     doubleJump = false;
                }
            }
             
        }

         }

   /* void Fire() 
    {
       // anim.SetTrigger("Fire");

        nextFire = Time.time + fireRate;

        GameObject cloneBullet = Instantiate(bulletObject, bulletSpawn.position, bulletSpawn.rotation);

        if(sprite.flipX)
        cloneBullet.transform.eulerAngles = new Vector3 (0,0,180);


    }*/
    
   

    void OnCollisionEnter2D(Collision2D  collision) {
        {
            if(collision.gameObject.layer == 8)
            {
                isJumping = false;
                anim.SetBool("jump", false);
            }
            if(collision.gameObject.tag == "Spike")
            {
                Controller.instance.ShowGameOver();
                Destroy(gameObject);
             }
        }
    }
    void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.tag == "Spike")
            {
                Controller.instance.ShowGameOver();
                Destroy(gameObject);
             }
    }

    void OnCollisionExit2D(Collision2D collision){
        if(collision.gameObject.layer == 8)
        {
            isJumping = true;
        }
    }


   /* IEnumerator Damage()
    {
        for(float i = 0f; i < 1f; i+= 0.1f)
        {
            sprite.enabled = false;
            yield return new WaitForSeconds(0.1f);
            sprite.enabled = true;
            yield return new WaitForSeconds(0.1F);
        }

        invunerable = false;

    }

    public void DamagePlayer()
    {
        if(isAlive)
        {
            invunerable = true;
            health--;
            StartCoroutine (Damage ());

            if(health < 1){
                isAlive = false;
                //anim.SetTrigger("Death");
                Invoke("ReloadLevel", 3f);
            }
        }
    }*/

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
