using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    //initializing variables
    public PlayerController player;
    public Quaternion playerOrientation;
    public Quaternion sourceOrientation;
    public Quaternion rotation;
    public Quaternion playerRotation;
    public bool leftright;
    public int playerDirection;
    public bool rotate;
    public float speed;
    public float playerSpeed;
    public float angle;
    public Rigidbody2D player_rb;
    public Quaternion minusRotation;



    // Use this for initialization
    void Start()
    {

        //defining variables
        rotate = false;
        speed = 0.5f;
        angle = 0.0f;
        sourceOrientation = transform.rotation;
        player = FindObjectOfType<PlayerController>();
        playerRotation = player.transform.rotation;
        player_rb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Rotates in the left direction by 90 degres
        if (Input.GetKeyDown("left"))
        {
            rotate = true;
            angle += 90;
        }

        //Rotates in the right direction by 90 degres
        if (Input.GetKeyDown("right"))
        {
            rotate = true;
            angle -= 90;
        }

        if (Input.GetKeyDown("up"))
        {
            rotate = true;
            angle += 180;
        }

        if (rotate == true)
        {
            rotation = Quaternion.Euler(0, 0, angle);
            minusRotation = Quaternion.Euler(0, 0, -(angle));
            if (sourceOrientation != rotation || sourceOrientation != minusRotation)
            {
                //Rotates
                transform.rotation = Quaternion.Lerp(sourceOrientation, rotation, speed);
                //Keeps the rotation of the player to be always straight
                player.transform.rotation = Quaternion.Lerp(playerRotation, playerRotation, playerSpeed);
                sourceOrientation = transform.rotation;
                //Disables rigid body
                player_rb.simulated = false;

            }

            else
            {
                rotate = false;
                player_rb.simulated = true;
            }
        }

    }
}