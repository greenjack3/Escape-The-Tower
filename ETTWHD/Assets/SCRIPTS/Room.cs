using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour {

    public int roomId = -1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        CharacterAI character = other.gameObject.GetComponent<CharacterAI>();
        if (character != null)
        {
            character.roomID = roomId;
        }
    }
}
