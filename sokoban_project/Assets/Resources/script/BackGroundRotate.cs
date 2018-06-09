using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundRotate : MonoBehaviour {
    
	void Update () {
        transform.Rotate(0, Time.deltaTime * 15, Time.deltaTime * 5);
    }
}
