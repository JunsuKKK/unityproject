using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {
    public void SC_main_stage1()
    {
        Fade.stage = 1;
        Fade.flag = 2;
    }

    public void StageBtn()
    {
        switch (ReturnStage.stage)
        {
            case 1:
                Fade.stage = 1;
                Fade.flag = 2;
                break;
            case 2:
                Fade.stage = 2;
                Fade.flag = 2;
                break;
            case 3:
                Fade.stage = 3;
                Fade.flag = 2;
                break;
            default:
                break;

        }
    }
    public static void StageStatic()
    {
        switch (ReturnStage.stage)
        {
            case 1:
                Fade.stage = 1 + 1;
                Fade.flag = 2;
                break;
            case 2:
                Fade.stage = 2 + 1;
                Fade.flag = 2;
                break;
            case 3:
                Fade.stage = 3 + 1;
                Fade.flag = 2;
                break;
            default:
                break;

        }
    }
}
