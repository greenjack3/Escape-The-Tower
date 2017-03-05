using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraControlScript : MonoBehaviour {

    public float MaxZoom;
    public float MinZoom;
    public Camera MainCam;
    public GameObject player;
    
    

    void Start()
    {
        MinZoom = 1.5f;
        MaxZoom = 7f;
        player = GameObject.FindGameObjectWithTag("Player");
        
    }
	
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0f) // forward
        {
            if (MainCam.orthographicSize <= MaxZoom)
            {
                MainCam.orthographicSize++;
            }
        }
        else if (Input.GetAxis("Mouse ScrollWheel") > 0f) // backwards
        {
            if (MainCam.orthographicSize >= MinZoom)
            {
                MainCam.orthographicSize--;
            }
        }


        transform.position = player.transform.position;

    }

 /*   void Zoom()
    {
        Input.mouseScrollDelta.
    }*/
}
