using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Preferencias : MonoBehaviour
{

    public Text _txtPontuacao;
    public Text _txtVida;
    public Text _txtNome;

    // Start is called before the first frame update
    void Start()
    {
        GravaInformacoes();
        LerInformacoes();
        //ApagaChave();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GravaInformacoes()
    {
        PlayerPrefs.SetInt("pontuacao_do_jogador", 1286);
        PlayerPrefs.SetInt("vida_do_jogador", 3);
        PlayerPrefs.SetString("nome_do_jogador", "Academia Unity");
    }

    void LerInformacoes()
    {
        _txtPontuacao.text  = PlayerPrefs.GetInt("pontuacao_do_jogador").ToString();
        _txtVida.text = PlayerPrefs.GetInt("vida_do_joagador").ToString();
        _txtNome.text = PlayerPrefs.GetString("nome_do_jogador0").ToString();
    }

    void ApagaChave()
    {
        PlayerPrefs.DeleteKey("nome_do_jogador");
        //PlayerPrefs.DeleteAll();
    }
}
