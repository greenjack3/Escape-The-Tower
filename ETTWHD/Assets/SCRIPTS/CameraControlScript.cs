using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraControlScript : MonoBehaviour {

    public float MaxZoom;
    public float MinZoom;
    public Camera MainCam;


    void Start()
    {
        MinZoom = 1.5f;
        MaxZoom = 7f;
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
    }

 /*   void Zoom()
    {
        Input.mouseScrollDelta.
    }*/
}
