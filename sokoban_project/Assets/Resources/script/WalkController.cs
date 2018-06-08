using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkController : MonoBehaviour {
    Rigidbody rigbody;
    Animator animator;
    GameObject stone1, stone2, stone3, stone4;
    int flag = 0;
    public static int boxcnt = 0;
    public float speed = 1f;
    float horizontalMove;
    float verticalMove;
    Vector3 movement;
    bool isPress=false;
    bool isPlay = false;

    void Start()
    {
        stone1 = GameObject.Find("stone_collider1");
        stone2 = GameObject.Find("stone_collider2");
        stone3 = GameObject.Find("stone_collider3");
        stone4 = GameObject.Find("stone_collider4");
    }

    // Update is called once per frame
    void Update () {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");
        KeyPress();
        AnimationUpdate();
    }

    bool KeyPress()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)
            || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow))
        {
            isPress = true;
        }
        else
        {
            isPress = false;
        }
        return  isPress;
    }

    void Awake()
    {
        rigbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void AnimationUpdate()
    {
        if (horizontalMove == 0 && verticalMove == 0)
        {
            animator.SetBool("IsWalking", false);
        }
        else
        {
            if (flag == 1)
            {
                animator.SetBool("IsPush", true);
                if (!isPlay)
                {
                    SoundManager.instance.PlayDragBoxSound();
                    isPlay = true;
                }
            }
            else
            {
                if (flag == 0)
                {
                    animator.SetBool("IsPush", false);
                    SoundManager.instance.StopDragBoxSound();
                    isPlay = false;
                }
                animator.SetBool("IsWalking", true);
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == stone1)
        {
            boxcnt++;
        }
        if (other.gameObject == stone2)
        {
            boxcnt++;
        }
        if (other.gameObject == stone3)
        {
            boxcnt++;
        }
        if (other.gameObject == stone4)
        {
            boxcnt++;
        }


        if (other.gameObject == stone1 || other.gameObject == stone2 ||
            other.gameObject == stone3 || other.gameObject == stone4)
        {
            flag = 1;
        }
        Debug.Log(boxcnt);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == stone1)
        {
            boxcnt--;
        }
        if (other.gameObject == stone2)
        {
            boxcnt--;
        }
        if (other.gameObject == stone3)
        {
            boxcnt--;
        }
        if (other.gameObject == stone4)
        {
            boxcnt--;
        }
        if (other.gameObject == stone1 || other.gameObject == stone2 ||
            other.gameObject == stone3 || other.gameObject == stone4)
        {
            flag = 0;
        }
        Debug.Log(boxcnt);
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

        rigbody.rotation = Quaternion.Slerp(rigbody.rotation, newRotation, speed * Time.deltaTime);
    }
}
