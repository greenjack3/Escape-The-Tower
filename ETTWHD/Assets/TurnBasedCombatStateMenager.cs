using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedCombatStateMenager : MonoBehaviour {
    public DetectionLogic det;
    private bool playerDetected;
  

    public enum BattleStates
    {
        OUTOFCOMBAT,
        START,
        PLAYERCHOICE,
        ENEMYCHOICE
    }

    private BattleStates currentState;

    void Start()
    {
        currentState = BattleStates.OUTOFCOMBAT;
        //  playerDetected = false;
        // playerDetected = gameObject.GetComponent<DetectionLogic>().CanSeePlayer();
        det = gameObject.GetComponent<DetectionLogic>();
    }

    void Update()
    {
        det = gameObject.GetComponent<DetectionLogic>();
        playerDetected = det;

        if (playerDetected == false)
        {
            currentState = BattleStates.OUTOFCOMBAT;
            Debug.Log("OutofCombat");
        }
        else
        {
            switch (currentState)
            {
                case (BattleStates.START):
                    Debug.Log("CombatStateStart");
                    break;
                case (BattleStates.PLAYERCHOICE):
                    Debug.Log("CombatStatePlayerChoice");
                    break;
                case (BattleStates.ENEMYCHOICE):
                    Debug.Log("CombatStateStartEnemyChoice");
                    break;
            }
        }
    }

    void OnGUI()
    {
        if (GUILayout.Button("NEXT STATE"))
        {
            if (currentState == BattleStates.OUTOFCOMBAT)
            {
                currentState = BattleStates.START;
            }
            else if (currentState == BattleStates.START)
            {
                currentState = BattleStates.PLAYERCHOICE;
            }
            else if (currentState == BattleStates.PLAYERCHOICE)
            {
                currentState = BattleStates.ENEMYCHOICE;
            }
            else if (currentState == BattleStates.ENEMYCHOICE)
            {
                currentState = BattleStates.START;
            }
        }
    }
}
