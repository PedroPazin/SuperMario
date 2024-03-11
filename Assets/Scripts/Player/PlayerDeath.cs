using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public int pontos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision){

        if(collision.gameObject.tag == "Enemy"){
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision){

        if(collision.gameObject.tag == "Kill"){
            
            pontos += 100;

        }
    }
}
