using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BlocoScore : MonoBehaviour
{
    public float maxHp;
    float hp;

    PlayerDeath playerDeath;
    // Start is called before the first frame update
    void Start()
    {
        hp = maxHp;

        playerDeath = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDeath>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){
            hp -= 1;
            playerDeath.pontos += 100;
            Death();
        }
    }

    void Death(){
        if(hp <= 0){
            Destroy(this.gameObject);
        }
    }
}
