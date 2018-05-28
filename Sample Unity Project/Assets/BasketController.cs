using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour {
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow)){
			this.transform.Translate (Vector3.right * 60.0f * Time.deltaTime);
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow)){
			this.transform.Translate (Vector3.left * 60.0f * Time.deltaTime);
		}
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			this.transform.Translate (Vector3.forward * 60.0f * Time.deltaTime);
		}
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			this.transform.Translate (Vector3.back * 60.0f * Time.deltaTime);
		}
	}
}

