using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstaculos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void OnCollisionEnter2D(Collision2D col) 
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);//carregar a cena que esta dentro parenteses
      //dentro de parenteses: cena ativa
    }
}
