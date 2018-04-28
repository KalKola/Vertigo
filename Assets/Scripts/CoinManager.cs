using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinManager : MonoBehaviour {

    public static int score;
    Text text;

    private void Start()
    {
        text = GetComponent<Text>();
        score = 0;
    }

    private void Update()
    {
        if (score < 0)
            score = 0;
        text.text = "" + score;

    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }

    public static void Reset()
    {
        score = 0;
    }
}
