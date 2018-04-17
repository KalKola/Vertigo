using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject currentSpawn;
    public GameObject centreRotation;
    private PlayerAnimController player;
    public GameObject Spawn;

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
        centreRotation.transform.rotation = new Quaternion(0, 0, 0, 0);
        player.transform.rotation = new Quaternion(0, 0, 0, 0);
        player.transform.position = Spawn.transform.position;

    }
}
