using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Fade : MonoBehaviour {
    public float animTime = 2f;
    private Image fadeImage;

    private float start = 1f;
    private float end = 0f;
    private float time = 0f;

    public static int flag = 0;//1=fadein 2=fadeout
    public static int stage = -2; //0=main -1=gameover -2=default

    private void Start()
    {
        fadeImage = GetComponent<Image>();
    }

    private void Update()
    {
        if (flag == 1)
        {
            PlayFadeIn();
        }
        else if (flag == 2)
        {
            PlayFadeOut();
        }
    }

    public void PlayFadeIn()
    {
        time += Time.deltaTime / animTime;
        Color color = fadeImage.color;
        color.a = Mathf.Lerp(start, end, time);
        fadeImage.color = color;
        MainBtnFade.flag = false;
        if (1.5 < time)
        {
            flag = 0;
            time = 0f;
        }
    }
    public void PlayFadeOut()
    {
        time += Time.deltaTime / animTime;
        Color color = fadeImage.color;
        color.a = Mathf.Lerp(end, start, time);
        fadeImage.color = color;
        MainBtnFade.flag = true;
        if (0.8 < time)
        {
            switch (stage)
            {
                case -1:
                    flag = 0;
                    SceneManager.LoadScene("game_over");
                    break;
                case 1:
                    flag = 0;
                    SceneManager.LoadScene("stage1_scene");
                    break;
                case 2:
                    flag = 0;
                    SceneManager.LoadScene("stage2_scene");
                    break;
                case 3:
                    flag = 0;
                    SceneManager.LoadScene("stage3_scene");
                    break;
                case 4:
                    flag = 0;
                    SceneManager.LoadScene("clear");
                    break;
            }
        }
    }
}
