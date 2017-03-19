using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {

    public Room[] rooms;

	// Use this for initialization
	void Start () {
        rooms = transform.GetComponentsInChildren<Room>();
        for (int i = 0; i < rooms.Length; i++)
        {
            rooms[i].roomId = i;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
