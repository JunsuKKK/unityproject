using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountController : MonoBehaviour {

    public Text time_Cnt;
    public float timeCoast;
    public string result;
    private void Start()
    {
        timeCoast = 30;
    }
    // Update is called once per frame
    void Update () {
        timeCoast -= Time.deltaTime;
        result = string.Format("{0:0.0}",timeCoast);
        time_Cnt.text = result;

        if (timeCoast <= 0)
        {
            SceneChange.Game_Over();
        }

	}
}
