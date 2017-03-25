using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAI : MonoBehaviour {

    public int roomID;
    CharacterMovementScript playerScript;
    public void Stop()
    {
        if (playerScript != null)
        {
            playerScript.StopPlayer();
        }
    }
    public void Block()
    {
        if (playerScript != null)
        {
            playerScript.BlockPlayer();
        }
    }

    public void UnBlock()
    {
        if (playerScript != null)
        {
            playerScript.StopBlockPlayer();
        }
    }

    // Use this for initialization
    void Start () {
        if (gameObject.CompareTag("Player"))
        {
            playerScript = GetComponent<CharacterMovementScript>();
        }
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

   public void PlayerAction()
    {
        Debug.Log("tura krasnala");
       // TurnBasedCombatStateMenager.Instance.EndPlayerTurn();
    }
    // Update is called once per frame
    void Update () {
		
	}
}
