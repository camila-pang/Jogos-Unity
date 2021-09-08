using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumeradores : MonoBehaviour
{   
    public enum Heroi { Parado, Correndo, Morrendo, Pulando}

    public Heroi acao;
    // Start is called before the first frame update
    void Start()
    {
        if(acao == Heroi.Correndo)
        {
            Debug.Log("Personagem Correndo");
        }
        else if( acao == Heroi.Morrendo)
        {
            Debug.Log("Personagem Morrendo");
        }
        else if( acao == Heroi.Parado)
        {
            Debug.Log("Personagem Parado");
        }
        else if( acao == Heroi.Pulando)
        {
            Debug.Log("Personagem Pulando");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
