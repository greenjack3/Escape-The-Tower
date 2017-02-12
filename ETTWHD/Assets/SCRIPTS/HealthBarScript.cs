using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarScript : MonoBehaviour {

    public Camera MainCam;

    void Start()
    {
//        MainCam = Camera.main;
    }

    void Update ()
    {
        MainCam = Camera.main;
        transform.LookAt(transform.position + MainCam.transform.rotation * Vector3.back, MainCam.transform.rotation * Vector3.down);
	}
}
