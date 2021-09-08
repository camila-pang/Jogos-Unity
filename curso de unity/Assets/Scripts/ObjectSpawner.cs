using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{  
     [Header("Alvos")]
     public GameObject prefab;


    [Header("GamePlay")]
    public float interval;
    public float minimiumX;
    public float maximumX;
    public float y;


    [Header ("Ovos")]
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", interval, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {   
        //instanciar e posicionar o objeto
        GameObject instance = Instantiate(prefab);
        instance.transform.position = new Vector2(Random.Range(minimiumX, maximumX), y);

        //set parent
        instance.transform.SetParent(transform);

        //seta um sprite
        Sprite randomSprite = sprites[Random.Range(0, sprites.Length)];
        instance.GetComponent<SpriteRenderer>().sprite = randomSprite;
    }
}
