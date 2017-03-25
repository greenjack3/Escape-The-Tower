using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : MonoBehaviour {

    public PlayerBase player;

    public enum TurnState
    {
        PROCESSING,
        ADDTOLIST,
        WAITING,
        SELECTING,
        ACTION,
        DEAD

    }

    public TurnState currentState;

    



    // Use this for initialization
    void Start () {
        currentState = TurnState.PROCESSING;

	}
	
	// Update is called once per frame
	void Update () {
	
        switch (currentState)
        {

            case (TurnState.PROCESSING):
                Debug.Log("Napisz PROCESSING");
                break;

            case (TurnState.ADDTOLIST):
                Debug.Log("Napisz ADDTOLIST");
                break;

            case (TurnState.WAITING):
                Debug.Log("Napisz WAITING");
                break;

            case (TurnState.SELECTING):
                Debug.Log("Napisz SELECTING");

                break;

            case (TurnState.ACTION):
                Debug.Log("Napisz ACTION");

                break;

            case (TurnState.DEAD):
                Debug.Log("Napisz DEAD");

                break;

        }
        
        
        
        
        	
	}
}
