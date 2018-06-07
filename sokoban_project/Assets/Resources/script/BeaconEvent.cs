using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeaconEvent : MonoBehaviour {
    GameObject stone1, stone2, stone3, stone4;
    void Awake()
    {
        Debug.Log("start");
           
        stone1 = GameObject.Find("stone1");
        stone2 = GameObject.Find("stone2");
        stone3 = GameObject.Find("stone3");
        stone4 = GameObject.Find("stone4");
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject == stone1|| other.gameObject == stone2||
            other.gameObject == stone3|| other.gameObject == stone4)
            {
            ScoreManager.score += 1;
            GetComponent<ParticleSystem>().Play();
            }

    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject == stone1 || other.gameObject == stone2 ||
            other.gameObject == stone3 || other.gameObject == stone4)
        {
            ScoreManager.score -= 1;
            GetComponent<ParticleSystem>().Stop();
        }

    }

}
