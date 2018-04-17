using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public LevelManager levelManager;
    public GameObject Player;
    public GameObject centreRotation;


    // Use this for initialization
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Boi")
        {
            levelManager.currentSpawn = gameObject;
            centreRotation.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }
}
