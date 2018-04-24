using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMove : MonoBehaviour {
    public PlayerAnimController player;
    public bool spawner;
    // Use this for initialization
    void Start () {
        spawner = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Boi")
        {
            spawner = true;
        }
        if (spawner)        
        {
            player.speed = 5;
            player.Caller();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        spawner = false;
        player.speed = 0;
        player.Caller();
    }
}
