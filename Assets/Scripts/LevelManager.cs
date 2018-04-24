using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public GameObject centreRotation;
    public PlayerAnimController player;
    public GameObject Spawn;
    private Rotate resetAngle;
    Vector3 tempPos;

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
        centreRotation.GetComponent<Rotate>().angle = 0.0f;
        player.transform.position = Spawn.transform.position;
        //tempPos = player.transform.position;
            // tempPos.x += 1;
            //player.transform.position = tempPos;
        

    }

    public void SwitchScenes()
    {
        SceneManager.LoadScene("justineRoom");
    }

    
}
