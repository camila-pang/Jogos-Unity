using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{   
    [Header("Variaveis de Velocidade")]
    public float minimunXSpeed;
    public float maximumXSpeed;
    public float minimunYSpeed;
    public float maximumYSpeed;

    [Header("Variavel do GamePlay")]
    public float lifeTime;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(
            Random.Range(minimunXSpeed, maximumXSpeed), 
            Random.Range(minimunYSpeed, maximumYSpeed)
        );

        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
