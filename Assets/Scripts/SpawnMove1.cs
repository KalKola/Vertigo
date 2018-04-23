using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMove1 : MonoBehaviour {

    public GameObject Player;
    public bool inSpawn = false;

    // Use this for initialization
    void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Boi")
        {
            inSpawn = true;
        }
        while (inSpawn == true)
        {
            Player.GetComponent<Rigidbody2D>().velocity = new Vector3(5, Player.GetComponent<Rigidbody2D>().velocity.y, 0); ;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        inSpawn = false;
    }
}
