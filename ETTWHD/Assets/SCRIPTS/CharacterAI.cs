using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAI : MonoBehaviour {

    public int roomID;

	// Use this for initialization
	void Start () {
        if (TurnBasedCombatStateMenager.Instance != null)
        {
            TurnBasedCombatStateMenager.Instance.RegisterCharacter(this);
        }
	}


    private void OnDisable()
    {
        if (TurnBasedCombatStateMenager.Instance != null)
        {
            TurnBasedCombatStateMenager.Instance.RemoveCharacter(this);
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
