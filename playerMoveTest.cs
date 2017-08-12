using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoveTest : MonoBehaviour
{
    public int playerSpeed = 10;
    private bool facingRight = false;
    public int playerJumpPower = 1250;
    private float moveX;
    public bool isGrounded;
    public bool canMove;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if(!canMove)
        {
            return;
        }

        playerMove();
    }
    void playerMove()
    {
        anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));
        //CONTROLS
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            Jump();
        }

        {

        }
        //ANIMATIONS
        //PLAYER DIRECTIONS
        if (moveX < 0.0f && facingRight == false)
        {
            flipPlayer();
        }
        else if (moveX > 0.0f && facingRight == true)
        {
            flipPlayer();
        }
        //PHYSICS
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }
    void Jump()
    {
        //JUMPING CODE
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
        isGrounded = false;
    }
    void flipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;


    }
    private void OnCollisionEnter2D(Collision2D col)
    {
       Debug.Log("Player has collided with " + col.collider.name);
       if (col.gameObject.tag == "ground")
        {
           isGrounded = true;
        }
    }
}
