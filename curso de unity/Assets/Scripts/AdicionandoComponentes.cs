using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdicionandoComponentes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            gameObject.AddComponent<Rigidbody2D>();//se colocar no start nao vai funcionar, porque precisa apertar a tecla enquanto o metodo start for chamada/carregado, se apertar depois, nao vai adiantar. 
        }
    }
}
