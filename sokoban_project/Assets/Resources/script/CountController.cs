using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountController : MonoBehaviour {

    public Text time_Cnt;
    public float timeCoast;
    public string result;
    private void Start()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "stage1_scene": timeCoast = 31; break;
            case "stage2_scene": timeCoast = 121; break;
            case "stage3_scene": timeCoast = 201; break;
            default: break;
        }
    }
    // Update is called once per frame
    void Update () {
        timeCoast -= Time.deltaTime;
        result = string.Format("{0:0.0}",timeCoast);

        if (timeCoast <= 0)
        {
            Fade.stage = -1;
            Fade.flag = 2;
        }
        else
        {
            time_Cnt.text = result;
        }

	}
}
