using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {
    public static void Game_Over()
    {
        SceneManager.LoadScene("game_over");
    }
	public void SC_main_stage1()
    {
        SceneManager.LoadScene("stage1_scene");
    }
    public static void SC_stage1_stage2()
    {
        SceneManager.LoadScene("stage2_scene");
    }
}
