using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood : MonoBehaviour
{

    private SpriteRenderer sr;
    private CircleCollider2D circle;

    public GameObject smoke;
   // public int Score;

    
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

  

    void OnTriggerEnter2D(Collider2D collider) 
    {
        if(collider.gameObject.tag == "Player")
        {
            sr.enabled = false;
            circle.enabled = false;
            smoke.SetActive(true);

           // GameController.instance.totalScore += Score;
           // GameController.instance.UpdateScoreText();
            
            Destroy(gameObject, 0.5f);
        }
    }
}
