using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoca : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroiObjeto",3f );
        InvokeRepeating("DestroiObjeto", 3f, 2f);//nome da funcao, tempo para iniciar a primeira chamada, intervalo entre as chamadas
    }

    // Update is called once per frame
    void Update()
    {
        //Invoke("nome da funcao", 3f);

        if(Input.GetKeyDown(KeyCode.P))
        {
            CancelInvoke("DestroiObjeto");
        }
    }

    void DestroiObjeto()
    {
        Debug.Log("Objeto Destruido");
    }
}
