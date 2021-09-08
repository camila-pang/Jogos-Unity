using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotinas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DestroiObjeto");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DestroiObjeto()
    {
        yield return new WaitForSeconds(3f);
        //yield return null;

        //o que eu devo executar apos 3 segundos, mas posso retornar nulo, sem precisar esperar 3 s

        Debug.Log("Objeto destruido");
    }
}
