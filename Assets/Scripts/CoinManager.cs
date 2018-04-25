using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class CoinManager : MonoBehaviour {
    //public PlayerAnimController p;
    public int pointsToAdd;
    public AudioSource tone;

     void OnTriggerEnter2D(Collider2D other)
    { 
        if(other.GetComponent<PlayerAnimController>() == null)
        {
            return;
        }
        ScoreManager.AddPoints(pointsToAdd);
        tone.Play();
        Destroy(gameObject);
    }
}
