using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public GameObject destination;
    public GameObject box;
    public GameObject player;
    public bool occupied;


    // Use this for initialization
    void Start() {
        occupied = false;
    }

    // Update is called once per frame
    void Update() {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "grabable"  && occupied != true)
        {
            box = collision.gameObject;
            box.transform.position = new Vector2(destination.transform.position.x, destination.transform.position.y);
            destination.gameObject.GetComponent<Teleport>().occupied = true;
            box.GetComponent<FixedJoint2D>().enabled = false;
        }

        if (collision.gameObject.tag == "Player" && occupied != true)
        {
            player = collision.gameObject;
            player.transform.position = new Vector2(destination.transform.position.x, destination.transform.position.y);
            destination.gameObject.GetComponent<Teleport>().occupied = true;
        }

    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        occupied = false;

    }

    /* 
     * Tried using an IEnumerator function but it teleports the box back.
     * 
    IEnumerator Teleporting()
    {
        yield return new WaitForSeconds(tp_time);
        box.transform.position = new Vector2(destination.transform.position.x, destination.transform.position.y);
    }*/
}
