using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{   
    public float tempoInicial = 0;
    public Text cronometro;
    public Text textoBotao;

    bool cronometroAtivo = false;

    // Start is called before the first frame update
    void Start()
    {
        cronometro.text = tempoInicial.ToString("F2")+"m";
    }

    // Update is called once per frame
    void Update()
    {
        if(cronometroAtivo) 
        {
            tempoInicial += Time.deltaTime;
            cronometro.text = tempoInicial.ToString("F2") + "m";
        }
    }

    public void botaoTempo() 
    {
        cronometroAtivo = !cronometroAtivo;
        textoBotao.text = cronometroAtivo ? "Pausar" : "Iniciar";
    }
}
