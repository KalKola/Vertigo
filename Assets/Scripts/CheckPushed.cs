using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 
 * 
 * 
 * Was used to make the block unmoveable unless grabbed, but the method messed with the rotation as the block would move back to 
 * original position when you rotate the block with the room.
 * 
 * 
public class CheckPushed : MonoBehaviour {

    public GameObject room;
    public bool beingPushed;
    float xPos;

	// Use this for initialization
	void Start () {
        xPos = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
        if (beingPushed == false|| room.GetComponent<Rotate>().rotate == true)
        {
            transform.position = new Vector3(xPos, transform.position.y);
        }
        else
        {
            xPos = transform.position.x;
        }

	}
}
*/