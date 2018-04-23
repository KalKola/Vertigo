using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RidgidBodyConstraints : MonoBehaviour {

    Rigidbody2D myRigidbody;
    Vector2 xAxis;
    public bool beingPushed;

    // Use this for initialization
    void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
        //Creates the constraints so the object doesn't rotate or fly upwards when still
        myRigidbody.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
	}
	
	// Update is called once per frame
	void Update () {

        beingPushed = GetComponent<CheckPushed>().beingPushed;
        if (beingPushed == true)
        {
            myRigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        else
        {
            myRigidbody.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
        }
	}
}
