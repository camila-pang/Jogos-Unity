using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eventos : MonoBehaviour
{

    public delegate void OnInformaDano();

    public event OnInformaDano onDano;

    // Start is called before the first frame update
    void Start()
    {
        onDano += MostraDano; 

        onDano();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MostraDano()
    {
        Debug.Log("Sofreu dano!");
    }
}
