using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAI : MonoBehaviour {

    public int roomID;
    CharacterMovementScript playerScript;
    PlayerStateMachine playerMachine;
    EnemyStateMachine enemyMachine;
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
            playerMachine = GetComponent<PlayerStateMachine>();
        }
        if (TurnBasedCombatStateMenager.Instance != null)
        {
            TurnBasedCombatStateMenager.Instance.ContinueCombat();
            TurnBasedCombatStateMenager.Instance.RegisterCharacter(this);
        }
        if (gameObject.CompareTag("Enemy"))
        {
            enemyMachine = GetComponent<EnemyStateMachine>();
        }
	}


    private void OnDisable()
    {
        if (TurnBasedCombatStateMenager.Instance != null)
        {
            Debug.Log("zginąłem" + gameObject.name);
            TurnBasedCombatStateMenager.Instance.RemoveCharacter(this);
        }
    }

   public void PlayerAction()
    {
        Debug.Log("tura krasnala");
        playerMachine.currentState = PlayerStateMachine.TurnState.WAITING;
       // TurnBasedCombatStateMenager.Instance.EndPlayerTurn();
    }
    // Update is called once per frame

        public void EnemyAction()
    {
        if (enemyMachine != null)
        {
            Debug.Log("tura przeciwnika");
            enemyMachine.currentState = EnemyStateMachine.TurnState.PROCESSING;
        }
    }

 //   void Update ()
 //   {
		
	//}
}
