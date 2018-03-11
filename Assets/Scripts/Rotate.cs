using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    
    //initializing variables
	public Quaternion sourceOrientation;
	public Quaternion rotation;
    public bool leftright;
    public bool rotate;
    public float speed;
    public float angle;




    // Use this for initialization
    void Start () {

        //defining variables
        rotate = false;
        angle = 0.0f;
        sourceOrientation = transform.rotation;
    }

	// Update is called once per frame
	void Update () {
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
        rotation = Quaternion.Euler(0, 0, angle);
        if (rotate == true)
		{
    
            if (sourceOrientation != rotation)
            {
                transform.rotation = Quaternion.Slerp(sourceOrientation, rotation, speed);
                sourceOrientation = transform.rotation;
            }

            else
            {
                rotate = false;
            }
        }
	}
}
