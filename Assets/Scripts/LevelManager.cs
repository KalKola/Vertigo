using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject currentSpawn;

    private PlayerAnimController player;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerAnimController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SpawnPlayer()
    {
        Debug.Log("Player Respawn");
        player.transform.position = currentSpawn.transform.position;
    }
}
