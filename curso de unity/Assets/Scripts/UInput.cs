using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UInput : MonoBehaviour
{   public Text txt;
    public InputField InputNome;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MostraMensagem() 
    {
        txt.text = InputNome.text;
    }
}
