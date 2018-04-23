using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPush : MonoBehaviour {

    public float distance = 0.5f;
    //Prevents the raycast from colliding with player
    public LayerMask boxMask;
    public GameObject object_forward;
    public GameObject object_backward;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {

        //This prevents the raycast from hitting the player if the player has 2 or more collidors.
        Physics2D.queriesStartInColliders = false;
        //Creates a raycast to know if the player is near a pushable box
        RaycastHit2D hit_forward = Physics2D.Raycast(transform.position, Vector2.right * 1, distance, boxMask);
        RaycastHit2D hit_backward = Physics2D.Raycast(transform.position, Vector2.left * 1, distance, boxMask);

        //Checks the object that the raycast collidor hits an object
        if (hit_backward.collider != null && hit_backward.collider.gameObject.tag == "grabable" && Input.GetKeyDown(KeyCode.E))
        {
            //Gets the object and enables the components 
            object_backward = hit_backward.collider.gameObject;
            object_backward.GetComponent<FixedJoint2D>().enabled = true;
            object_backward.GetComponent<CheckPushed>().beingPushed = true;
            object_backward.GetComponent<FixedJoint2D>().connectedBody = GetComponent<Rigidbody2D>();
            
        }//Disables component 
        else if (Input.GetKeyUp(KeyCode.E)&& hit_backward.collider != null )
        {
            
            object_backward.GetComponent<FixedJoint2D>().enabled = false;
            object_backward.GetComponent<CheckPushed>().beingPushed = false;
        }



        if (hit_forward.collider != null && hit_forward.collider.gameObject.tag == "grabable" && Input.GetKeyDown(KeyCode.E))
        {
            object_forward = hit_forward.collider.gameObject;
            object_forward.GetComponent<FixedJoint2D>().enabled = true;
            object_forward.GetComponent<CheckPushed>().beingPushed = true;
            object_forward.GetComponent<FixedJoint2D>().connectedBody = GetComponent<Rigidbody2D>();

        }
        else if(Input.GetKeyUp(KeyCode.E) && hit_forward.collider != null)
        {
            object_forward.GetComponent<FixedJoint2D>().enabled = false;
            object_forward.GetComponent<CheckPushed>().beingPushed = false;
        }


    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.right * 1 * distance);
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.left * 1 * distance);
    }
}
