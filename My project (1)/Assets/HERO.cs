using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HERO : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float jump;
    public bool canJump;
    Animator anim;
    SpriteRenderer sprite;
    void Start()
    {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //flips the character:
        if (Input.GetAxis("Horizontal") > 0)
            sprite.flipX = false;
        else if (Input.GetAxis("Horizontal") < 0)
            sprite.flipX = true;


        Vector2 temp = rb.velocity;


        //jumping:
        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            temp.y = jump;
            canJump = false;
        }

        if (rb.velocity.y != 0)
        {
            anim.SetBool("run", false);
            anim.SetBool("jump", true);
        }

        //running:
        temp.x = Input.GetAxis("Horizontal") * speed;
        rb.velocity = temp;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground" && rb.velocity.x != 0)
        {
            // no animation for jumping
            canJump = true;
            anim.SetBool("jump", false);

            // animation for walking 
            anim.SetBool("run", true);
        }
        else if (collision.gameObject.tag == "ground" && Input.anyKey == false)
        {
            // no anomation for jumping
            canJump = true;
            anim.SetBool("jump", false);

            //  no animation for walking 
            anim.SetBool("run", false);
        }

    }
}
