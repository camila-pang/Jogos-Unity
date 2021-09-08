using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiDelegate : MonoBehaviour
{

    delegate void ExecuteMeuDelegate();
    ExecuteMeuDelegate execute;

    // Start is called before the first frame update
    void Start()
    {
        execute += MostraInformacao;
        execute += GanhaForca;

        if(execute != null)
        {
            execute();

            execute -= MostraInformacao;
            execute -= GanhaForca;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MostraInformacao()
    {
        Debug.Log("Ola");
    }

    void GanhaForca()
    {
        Debug.Log("Você ganhou mais forca");
    }
}
