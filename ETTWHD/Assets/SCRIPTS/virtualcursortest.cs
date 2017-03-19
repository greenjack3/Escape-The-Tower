using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virtualcursortest : MonoBehaviour {

    
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
            transform.position = hit.point;

        transform.position = new Vector3(transform.position.x, 0.75f, transform.position.z);


    }
}
