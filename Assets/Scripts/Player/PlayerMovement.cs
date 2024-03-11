using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    bool canJump;

    private Rigidbody2D rb;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
       

    void Update()
    {
        Jump();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move(){
        float horizontal = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(horizontal * speed * Time.fixedDeltaTime, rb.velocity.y);
        if(horizontal != 0){
            SetAnimator(horizontal, 0, 1);
        }
        else{
            animator.SetLayerWeight(1, 0);
        }
    }

    void SetAnimator(float horizontal, float vertical, int layer){
        animator.SetLayerWeight(layer, 1);
        animator.SetFloat("xDir", horizontal);
        animator.SetFloat("yDir", vertical);
    }

    void Jump(){
        if(canJump && Input.GetKey(KeyCode.Space)){

            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            canJump = false;

            
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Chao"){
            canJump = true;
        }
        
    }
}
