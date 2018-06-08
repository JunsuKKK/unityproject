using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxStackController : MonoBehaviour {
    GameObject stone1, stone2, stone3, stone4, player;
    // Use this for initialization
    public Rigidbody rb;
    public Collider myStone;
        
        void Start()
    {
        rb = GetComponent<Rigidbody>();
        myStone = GetComponent<Collider>();
        stone1 = GameObject.Find("stone_collider1");
        stone2 = GameObject.Find("stone_collider2");
        stone3 = GameObject.Find("stone_collider3");
        stone4 = GameObject.Find("stone_collider4");
        player = GameObject.Find("Character_Male");
    }

    // Update is called once per frame
    void Update () {
     
    }


    private void OnTriggerEnter(Collider other)
    {
        if (((other.gameObject == stone1 || other.gameObject == stone2 ||
            other.gameObject == stone3 || other.gameObject == stone4) && other.gameObject != player) || WalkController.boxcnt >= 2)
        {
            rb.isKinematic = true;
        }
        else
        {
            rb.isKinematic = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == stone1 || other.gameObject == stone2 ||
            other.gameObject == stone3 || other.gameObject == stone4)
        {
            rb.isKinematic = false;
        }
        if ((other.gameObject == stone1 || other.gameObject == stone2 ||
            other.gameObject == stone3 || other.gameObject == stone4) && other.gameObject == player)
        {
            rb.isKinematic = false;
        }
    }

}

