using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnStage : MonoBehaviour {

    public static int stage;

    private void Awake()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "stage1_scene":
                stage = 1;
                break;
            case "stage2_scene":
                stage = 2;
                break;
            case "stage3_scene":
                stage = 3;
                break;
            default: break;
        }
    }
}
