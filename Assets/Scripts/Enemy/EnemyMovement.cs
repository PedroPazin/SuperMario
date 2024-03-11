using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    int direction = 1;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }
    
    void Move(){
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(speed * Time.fixedDeltaTime, 0);
        animator.SetFloat("xDir", direction);
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Wall"){
            speed *= -1;
            direction *= -1;
        }
    }
}
