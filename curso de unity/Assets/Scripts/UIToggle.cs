using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIToggle : MonoBehaviour
{   public Toggle SelecaoNome;
public Text DigiteNome;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Status() 
    {
        if(SelecaoNome.isOn == true) 
        {

          //DigiteNome.readOnly = false;
        }
        else {
          //  DigiteNome.readOnly = true;
        }
    }
}
