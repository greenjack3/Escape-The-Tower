using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateMachine : MonoBehaviour {

    public enum PerformAction
    {
        WAIT,
        TAKEACTION,
        PERFORMACTION


    }

    public PerformAction battleStates;

    public List<HandleTurns> PerformList = new List <HandleTurns> ();
    public List<GameObject> HerosInBattle = new List<GameObject>();
    public List<GameObject> EnemiesInBattle = new List<GameObject>();
    public GameObject performer;





	// Use this for initialization
	void Start () {

        battleStates = PerformAction.WAIT;

        EnemiesInBattle.AddRange(GameObject.FindGameObjectsWithTag ("Enemy"));  // wszyscy przeciwnicy w grze
        HerosInBattle.Add(GameObject.FindGameObjectWithTag ("Player")); // cały jeden hero player

		
	}
	
	// Update is called once per frame
	void Update () {
		
        switch(battleStates)
        {

            case (PerformAction.WAIT):
                if (PerformList.Count > 0)
                {

                    battleStates = PerformAction.TAKEACTION;
                
                }




                break;

            case (PerformAction.TAKEACTION):
               // GameObject perfomer = GameObject.Find(PerformList[0].Attacker);

                GameObject perfomer = GameObject.FindGameObjectWithTag("Enemy");
                if (PerformList[0].Type == "Enemy")
                {
                    
                   Debug.Log(perfomer);
                    EnemyStateMachine ESM = perfomer.GetComponent<EnemyStateMachine>();
                    ESM.playerToAttack = PerformList[0].AttackersTarget;
                    ESM.currentState = EnemyStateMachine.TurnState.ACTION;    
                    
                }


                break;

                case (PerformAction.PERFORMACTION):
                break;

        }



	}

    public void CollectActions(HandleTurns input)
    {
        PerformList.Add(input);

    }



}
