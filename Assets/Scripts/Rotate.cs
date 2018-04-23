using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    //initializing variables
    public AudioSource rotatesfx;
    public PlayerAnimController player;
    public Quaternion playerOrientation;
    public Quaternion sourceOrientation;
    public Quaternion rotation;
    public Quaternion playerRotation;
    public bool leftright;
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
        speed = 0.5f;
        angle = 0.0f;
        sourceOrientation = transform.rotation;
        player = FindObjectOfType<PlayerAnimController>();
        playerRotation = player.transform.rotation;
        player_rb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            rotate = true;
            angle += 90;
        }

        if (Input.GetKeyDown("right"))
        {
            rotate = true;
            angle -= 90;
        }

        if (rotate == true)
        {
            rotatesfx.Play();
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