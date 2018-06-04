using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
    public static int score;
    public static int maxscore;

    // Use this for initialization
    private void Awake()
    {
        maxscore = 4;
        score = 0;
    }
    private void Update()
    {
        if (score == 4)
        {
            Debug.Log("444");
        }
    }
}
