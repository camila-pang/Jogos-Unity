using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{

    public Text distancia;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        distancia.text = "0 m";
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        distancia.text = count.ToString() + "m";
    }
}
