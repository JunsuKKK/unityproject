using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreController : MonoBehaviour {

    Text scoreLabel;
    
	void Awake () {
        scoreLabel = GetComponent<Text>();
	}
	
	void Update () {
        scoreLabel.text = ScoreManager.score.ToString();
	}
}
