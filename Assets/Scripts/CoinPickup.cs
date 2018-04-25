using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour {

    public int pointsToAdd;
    public AudioSource coinsfx;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<PlayerAnimController>() == null)
        {
            return;
        }
        ScoreManager.AddPoints(pointsToAdd);

        Destroy(gameObject);
        coinsfx.Play();
    }
}
