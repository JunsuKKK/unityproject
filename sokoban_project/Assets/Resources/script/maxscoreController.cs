using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class maxscoreController : MonoBehaviour {

    Text maxscoreLabel;
    
    void Awake()
    {
        maxscoreLabel = GetComponent<Text>();
    }
    
    void Update()
    {
        maxscoreLabel.text = ScoreManager.maxscore.ToString();
    }
}
