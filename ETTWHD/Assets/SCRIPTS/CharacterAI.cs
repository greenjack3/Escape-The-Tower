using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class CharacterAI : MonoBehaviour {

    public int roomID;
    CharacterMovementScript playerScript;
    PlayerStateMachine playerMachine;
    EnemyStateMachine enemyMachine;
    NavMeshAgent agent;
    NavMeshPath currentPath;
    public int actionPoints = 5;
    public float maxDistanceToPlayer = 20f;
    Vector3 finalPosition;
    Vector3 toNextPoint;
    public float traveledDistance;
   public float maxTravelDistance;
    float distanceToPlayer;

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
        currentPath = new NavMeshPath();
        agent = GetComponent<NavMeshAgent>();
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
    public List<Vector3> finalPath = new List<Vector3>();
    public float distanceDifference;
    public float currentDistance;
    //wyswietlanie sciezki do gracza (dziala w dystansie maxDistanceToPlayer ~20m)
    private void OnDrawGizmos()
    {
        int maxPathCorner = 0;
        traveledDistance = 0f;
        finalPath.Clear();
        if (currentPath != null)
        {
            //wyswietlanie calej sciezki
            //Gizmos.color = Color.magenta;
            //for (int i = 1; i < currentPath.corners.Length; i++)
            //{
              
               
            //    Gizmos.DrawLine(currentPath.corners[i - 1], currentPath.corners[i]);
                
            //}
            //obliczanie dystansu, jaki mozemy przejsc
            maxTravelDistance = (float)actionPoints * 1f;
            for (int i = 1; i < currentPath.corners.Length; i++)
            {
                currentDistance = Vector3.Distance(currentPath.corners[i - 1], currentPath.corners[i]);
                traveledDistance += currentDistance;

                if (traveledDistance >= maxTravelDistance)
                {
                    toNextPoint = (currentPath.corners[i] - currentPath.corners[i - 1]).normalized;
                    distanceDifference = currentDistance - (traveledDistance - maxTravelDistance);
                    maxPathCorner = i;
                    finalPosition = currentPath.corners[maxPathCorner - 1] + toNextPoint * distanceDifference;
                    finalPath.Add(finalPosition);
                    break;
                }
                else
                {
                    finalPath.Add(currentPath.corners[i]);
                    finalPath.Add(currentPath.corners[i - 1]);
                }
            }
            Gizmos.color = Color.green;
            for (int i = 1; i < finalPath.Count; i++)
            {
                Gizmos.DrawLine(finalPath[i - 1], finalPath[i]);
            }
            
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

    void Update()
    {
        if (TurnBasedCombatStateMenager.Instance != null)
        {
            if (TurnBasedCombatStateMenager.Instance.playerCharacter != null)
            {
                distanceToPlayer = Vector3.Distance(TurnBasedCombatStateMenager.Instance.playerCharacter.transform.position, transform.position);
                if (distanceToPlayer <= maxDistanceToPlayer)
                {
                    if (agent != null)
                    {
                        agent.CalculatePath(TurnBasedCombatStateMenager.Instance.playerCharacter.transform.position, currentPath);
                    }
                   
                }
            }
        }
    }
}
