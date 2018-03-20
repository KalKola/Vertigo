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




    // Use this for initialization
    void Start()
    {

        //defining variables
        rotate = false;
        playerDirection = 0;
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
        if (Input.GetKeyDown("left"))
        {
            rotate = true;
            //playerDirection = -1;
            angle += 90;
        }

        if (Input.GetKeyDown("right"))
        {
            rotate = true;
            //playerDirection = 1;
            angle -= 90;
        }

        if (Input.GetKeyDown("up"))
        {
            rotate = true;
           // playerDirection = 2;
            angle += 180;
        }

        if (rotate == true)
        {
            rotation = Quaternion.Euler(0, 0, angle);
            if (sourceOrientation != rotation)
            {
                transform.rotation = Quaternion.Lerp(sourceOrientation, rotation, speed);
                player.transform.rotation = Quaternion.Lerp(playerRotation, playerRotation, playerSpeed);
                sourceOrientation = transform.rotation;
                player_rb.isKinematic = true;

            }

            else
            {
                rotate = false;
                player_rb.isKinematic = false;
            }
        }

    }
}