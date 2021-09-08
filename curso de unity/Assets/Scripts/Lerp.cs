using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    public Transform inicio;
    public float fim = 5f;
    public float tempo = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.Lerp(inicio.position.x, fim, tempo += 0.1f), transform.position.y);
    }
}
