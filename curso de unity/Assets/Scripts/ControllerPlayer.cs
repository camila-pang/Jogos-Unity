using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : MonoBehaviour {

    private Animator    playerAnimator;
    private Rigidbody2D playerRigidbody2D;
    public  Transform   groundCheck;

    public  bool        isGrounded;
    public  bool        facingRight = true;

    public  float       speed;
    public  float       direcao;

    // Pulo
    public  bool        jump = false;
    public  float       jumpForce;

    public  int         numberJumps = 0;
    public  int         maximoJumps = 2;


  [Header("Limite do Personagem")]
  public Transform limiteEsquerdo;
  public Transform limiteDireito;
    
	// Use this for initialization
	void Start () {

        playerAnimator = GetComponent<Animator>();
        playerRigidbody2D = GetComponent<Rigidbody2D>();
		
	}

    void LimitaMovimentoPersonagem()
    {
        float posicaoX = transform.position.x;

        if(posicaoX > limiteDireito.position.x)
        {
            transform.position = new Vector3(limiteDireito.position.x, transform.position.y, 0);
        }
        else if(posicaoX < limiteEsquerdo.position.x)
        {
            transform.position = new Vector3(limiteEsquerdo.position.x, transform.position.y, 0);
        }

    }
	
	// Update is called once per frame
	void Update () {

        isGrounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        Debug.Log(isGrounded);

        playerAnimator.SetBool("isGrounded", isGrounded);

        direcao = Input.GetAxisRaw("Horizontal");
        Debug.Log(direcao);

        ExecutaMovimentos();

        if(Input.GetButtonDown("Jump")) // && isGrounded
        {
            jump = true;
        }

        LimitaMovimentoPersonagem();
		
	}

    private void FixedUpdate()
    {
        MovePlayer(direcao);

        if(jump)
        {
            JumpPlayer();
        }
    }

    void JumpPlayer()
    {

        if (isGrounded)  // true
        {
            numberJumps = 0;
        }

        if(isGrounded || numberJumps < maximoJumps )
        {
            playerRigidbody2D.AddForce(new Vector2(0f, jumpForce));
            numberJumps++;
            isGrounded = false;
        }
        jump = false;

    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void ExecutaMovimentos()
    {
        playerAnimator.SetFloat("velocidadeY", playerRigidbody2D.velocity.y);

        playerAnimator.SetBool("Jump", !isGrounded); // true ou false
        playerAnimator.SetBool("Run", playerRigidbody2D.velocity.x != 0f && isGrounded );


    }

    void MovePlayer(float movimentoH)
    {
        playerRigidbody2D.velocity = new Vector2(movimentoH * speed, playerRigidbody2D.velocity.y);
        if( movimentoH < 0 && facingRight || (movimentoH > 0 && !facingRight))
        {
            Flip();
        }
    }


}
