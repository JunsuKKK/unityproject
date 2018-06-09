using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainBtnFade : MonoBehaviour {
    public static bool flag;
    private Image btnImage;
    public float animTime = 2f;
    private float start = 1f;
    private float end = 0f;
    private float time = 0f;

    // Use this for initialization
    void Awake () {
        btnImage = GetComponent<Image>();
        flag = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (flag && btnImage!=null)
        {
            time += Time.deltaTime / animTime;
            Color color = btnImage.color;
            color.a = Mathf.Lerp(start, end, time);
            btnImage.color = color;
            if (0.8 < time)
            {
                flag = false;
            }
        }
        else if (!flag && btnImage != null)
        {
            time += Time.deltaTime / animTime;
            Color color = btnImage.color;
            color.a = Mathf.Lerp(end, start, time);
            btnImage.color = color;
            if (0.8 < time)
            {
                flag = false;
            }
        }
    }
}
