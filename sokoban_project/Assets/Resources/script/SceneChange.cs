using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {
    public static void Game_Over()
    {
        Fade.stage = -1;
        Fade.flag = 2;
    }
    public void SC_main_stage1()
    {
        Fade.stage = 0;
        Fade.flag = 2;
    }

    public static void SC_stage1_stage2()
    {
        SceneManager.LoadScene("stage2_scene");
    }
}
