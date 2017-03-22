using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CombatInfo
{
    public int position = - 1;
    public CharacterAI character;
}


public class TurnBasedCombatStateMenager : MonoBehaviour {

    public static TurnBasedCombatStateMenager Instance;
    public bool det;
    private bool playerDetected;
    public int queue;
    public List<CharacterAI> allCharacters = new List<CharacterAI>();
    public List<CharacterAI> charactersInRoom = new List<CharacterAI>();
    public List<CombatInfo> combatInfos = new List<CombatInfo>();
    public CharacterAI playerCharacter;
    public bool playerTurn;




    public void RegisterCharacter(CharacterAI character)
    {
        if (!allCharacters.Contains(character))
        {
            allCharacters.Add(character);
        }
    }
    public void RemoveCharacter(CharacterAI character)
    {
        if (allCharacters.Contains(character))
        {
            allCharacters.Remove(character);
        }
    }

    private void Awake()
    {
        Instance = this;
    }

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
        GameObject playerOb = GameObject.FindGameObjectWithTag("Player");
        playerCharacter = playerOb.GetComponent<CharacterAI>();
        currentState = BattleStates.OUTOFCOMBAT;
        //  playerDetected = false;
        // playerDetected = gameObject.GetComponent<DetectionLogic>().CanSeePlayer();
       // det = gameObject.GetComponent<DetectionLogic>();
    }


    public void EndPlayerTurn()
    {
        playerTurn = false;
    }

    public void PlayerDetected()
    {
        if (!playerDetected)
        {
            playerDetected = true;
            EnterCombat();
        }
    }

    void EnterCombat()
    {
        playerCharacter.Stop();
        playerTurn = true;
        Debug.Log("ENTERING COMBAT");
        charactersInRoom.Add(playerCharacter);
        for (int i = 0; i < allCharacters.Count; i++)
        {
            if (allCharacters[i] != playerCharacter)
            {
                if (allCharacters[i].roomID == playerCharacter.roomID)
                {
                    charactersInRoom.Add(allCharacters[i]);
                }
            }
        }
        if (charactersInRoom.Count > 0)
        {
            
            if (playerTurn)
            {
                playerCharacter.UnBlock();
                playerCharacter.PlayerAction();
            }
            if (!playerTurn)
            {
                playerCharacter.Block();
                Debug.Log("tura przeciwnika");
            }
        }
    }

    int GetQueue(CharacterAI character)
    {
        if (charactersInRoom.Contains(character))
        {
            return charactersInRoom.IndexOf(character);
        }
        return -1;
    }

    //public void BattleStartUpdate()
    //{

    //}
    public void PlayerControlUpdate()
    {

    }
    public void EnemyControlUpdate()
    {

    }

    
    void Update()
    {

        switch (currentState)
        {
            //case BattleStates.START: BattleStartUpdate(); break;
            case BattleStates.PLAYERCHOICE: PlayerControlUpdate(); break;
            case BattleStates.ENEMYCHOICE: EnemyControlUpdate(); break;

        }
        //if (currentState == BattleStates.OUTOFCOMBAT)
        //{
        //   // det = gameObject.GetComponent<DetectionLogic>().playerDetected;
        //    //playerDetected = det;
        //    if (playerDetected)
        //    {
        //        queue = 0;
        //    }
        //    Debug.Log("OutofCombat");
        //}

        //if (queue == -1 && currentState != BattleStates.START)
        //{
        //    currentState = BattleStates.START;
        //}
        //if (queue == 0 && currentState != BattleStates.PLAYERCHOICE)
        //{
        //    currentState = BattleStates.PLAYERCHOICE;
        //}
        //if (queue > 0 && currentState != BattleStates.ENEMYCHOICE)
        //{
        //    currentState = BattleStates.ENEMYCHOICE;
        //}
    }
}
