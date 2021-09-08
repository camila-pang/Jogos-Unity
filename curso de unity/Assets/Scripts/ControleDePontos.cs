using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleDePontos : MonoBehaviour
{
    public int pontuacao;

    //antes do script ser carregado
     void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            pontuacao++;
            Debug.Log("Pontods da Fase" + pontuacao.ToString());
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("Fase02");
        }
    }
}
