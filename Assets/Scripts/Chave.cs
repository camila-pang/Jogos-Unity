using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chave : MonoBehaviour
{

    public GameObject portaParaAbrir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col) 
    {   
        FindObjectOfType<GerenciadorDeSons>().TocarSomDaChave();
        Destroy(portaParaAbrir);
        Destroy(this.gameObject);
    }
}
