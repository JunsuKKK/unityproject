using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkController : MonoBehaviour {
    Rigidbody rigbody;
    Animator animator;

    public float speed = 1f;
    float horizontalMove;
    float verticalMove;
    Vector3 movement;

    void Start()
    {

    }

    // Update is called once per frame
    void Update () {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");

        AnimationUpdate();
    }

    void Awake()
    {
        rigbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void AnimationUpdate()
    {
        if(horizontalMove == 0 && verticalMove == 0)
        {
            animator.SetBool("IsWalking", false);
        }
        else
        {
            animator.SetBool("IsWalking", true);
        }
    }
  
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Turn();
        Run(h, v);
    }

    void Run(float h, float v)
    {
        movement.Set(h, 0, v);
        movement = movement.normalized * Time.deltaTime;

        rigbody.MovePosition(transform.position + movement);
    }

    void Turn()
    {
        if(horizontalMove==0 & verticalMove == 0)
            return;
        Quaternion newRotation = Quaternion.LookRotation(movement);
        rigbody.MoveRotation(newRotation);
    }
}
