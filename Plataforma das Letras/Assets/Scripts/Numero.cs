using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numero : MonoBehaviour
{

    public AudioClip clip;
    private float timeVida;
    public float tempoMaximoVida;

    // Start is called before the first frame update
    void Start()
    {
        timeVida = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeVida += Time.deltaTime;
        if(timeVida >= tempoMaximoVida) {
            
            Destroy(gameObject);
            timeVida = 0;
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        
    }
}
