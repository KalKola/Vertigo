using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpHeight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
    private bool doubleJump;

    //Collidors
    List<Collider2D> inCollidors = new List<Collider2D>();

    // Use this for initialization
    void Start ()
    {
		
	}

    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    // Update is called once per frame
    void Update ()
    {
        if(grounded)
        {
            doubleJump = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }
        if (Input.GetKeyDown(KeyCode.Space) && !doubleJump && !grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
            doubleJump = true; 
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        //Makes all triggers/collidors in the list, use their "Use" function.
        if (Input.GetButtonDown("e"))
        {
            inCollidors.ForEach(n => n.SendMessage("Use", SendMessageOptions.DontRequireReceiver));
        }

    }

    //On trigger, adds a collidor to the list
    private void OnTriggerEnter2D(Collider2D collision)
    {
        inCollidors.Add(collision);
    }

    //On trigger, removes a collidor to the list
    private void OnTriggerExit2D(Collider2D collision)
    {
        inCollidors.Remove(collision);
    }
}
