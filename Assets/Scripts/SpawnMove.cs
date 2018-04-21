using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMove : MonoBehaviour {

    private PlayerAnimController PAC;
    public GameObject Player;

	// Use this for initialization
	void Start () {

        PAC = FindObjectOfType<PlayerAnimController>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        while (other.name == "Boi")
        {
            PAC.MovePlayer(10);
        }
    }
}
