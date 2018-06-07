using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera_Action : MonoBehaviour {

    public GameObject player;
    Vector3 cameraPosition;
    
    public float offsetX=-1f;
    public float offsetY=5f;
    public float offsetZ=-3f;
    public float followSpeed = 1f;

    private void LateUpdate()
    {

        cameraPosition.x = player.transform.position.x + offsetX;
        cameraPosition.y = player.transform.position.y + offsetY;
        cameraPosition.z = player.transform.position.z + offsetZ;

        transform.position = Vector3.Lerp(transform.position, cameraPosition, followSpeed * Time.deltaTime);

    }

}
