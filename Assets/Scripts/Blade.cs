using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour {

    public float rotationSpeed;
    public LevelManager levelManager;

    // Use this for initialization
    void Start () {
        levelManager = FindObjectOfType<LevelManager>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(new Vector3(0, 0, rotationSpeed));
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Boi")
        {
            levelManager.SpawnPlayer();
        }
    }
}

