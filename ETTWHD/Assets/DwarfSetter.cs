using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DwarfSetter : MonoBehaviour {
    public GameObject player;
    public GameObject playerSpawner;
	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerSpawner = GameObject.FindGameObjectWithTag("PlayerSpawner");

        player.transform.position = new Vector3(1.75f, 0f, -2.41f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
