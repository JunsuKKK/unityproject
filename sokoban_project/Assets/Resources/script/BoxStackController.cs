using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxStackController : MonoBehaviour {
    GameObject stone1, stone2, stone3, stone4, player;
    // Use this for initialization
    public Rigidbody rb;
    public Collider myStone;
    bool isk=false;        
        void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("Character_Male");
    }

    // Update is called once per frame
    void Update () {
        if (isk && WalkController.boxcnt<2)
        {
            rb.isKinematic = false;
        }
        else if(!isk && WalkController.boxcnt==0)
        {
            rb.isKinematic = true;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player){
            isk = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isk = false;
    }

}

