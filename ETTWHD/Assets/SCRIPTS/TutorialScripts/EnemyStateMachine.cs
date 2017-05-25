using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[System.Serializable]
public class EnemyStateMachine : MonoBehaviour {

    public EnemyBase enemy;
    // public BattleStateMachine BSM;
    public GameObject player;
   public float timeLeft = 1.0f;
    public float timer = 0.1f;
    public bool startTimer = false;
    public int AtkStr;
    public Animator anim;
    public DetectionLogic det;
    public bool detected;
    public float actionDecision;
    public float actionTime;
    public bool isActionTime;
    public float xPos;
    public float zPos;
    public float xPos2;
    public float zPos2;
    public bool playerDetected;
    Vector3 targetDest;
    NavMeshAgent agent;
    //public float waitingTime;
    //public bool isWaitingTime;
    public float megaTimer;
    public bool isMegaTime;
    public enum TurnState
      
    {
        PROCESSING,
        CHOOSEACTIONS,
        WAITING,
        ACTION,
        DEAD

    }



    public TurnState currentState;


    private Vector3 startPosition;

    //private bool actionStarted = false;
    //public GameObject playerToAttack;
    //private float animSpeed = 5f;

    // Use this for initialization
    void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        det = gameObject.GetComponent<DetectionLogic>();
        // currentState = TurnState.PROCESSING;
        //BSM = GameObject.Find("BattleManager").GetComponent<BattleStateMachine> ();
        //startPosition = transform.position;
        isActionTime = false;
        //isWaitingTime = true;
        megaTimer = 3f;
        isMegaTime = true;
    }

    // Update is called once per frame
    void Update ()
    {
        if (startTimer == true)
        {
            timer -= Time.deltaTime;
        }


        if (timer < 0)
        {
            anim.SetInteger("AnimControl", 0);
            currentState = TurnState.WAITING;
            startTimer = false;
            timer = 0.1f;
        }


        if(isActionTime == true)
        {
            actionTime -= Time.deltaTime;
        }

        if(actionTime <= 0)
        {
            //isWaitingTime = true;
            agent.isStopped = true;
            agent.ResetPath();
            currentState = TurnState.WAITING;
        }
        if(isMegaTime == true)
        {
            megaTimer -= Time.deltaTime;
        }
       // megaTimer -= Time.deltaTime;

        if(megaTimer < 0)
        {
            actionDecision = Random.Range(0, 100);
            megaTimer = 3f;

        }
        //if(isWaitingTime == true)
        //{
        //    waitingTime -= Time.deltaTime;
        //}
        //detected = det.playerDetected;
        switch (currentState)
        {

            case (TurnState.PROCESSING):                                // chcę zapierdolić krasnoluda!
                                                                        //    Debug.Log("Napisz PROCESSING; śmierć wszystkim kransoludom yebanym!");
                Debug.Log("chce zabijać krasnale");
                //isWaitingTime = false;
                isActionTime = false;
                isMegaTime = false;
                timeLeft -= Time.deltaTime;
                if (timeLeft < 0)
                {
                    Debug.Log("zayebie tego krasnala " + gameObject.name);
                    anim.SetInteger("AnimControl", 2);
                    startTimer = true;
                    player.SendMessage("CalculateDamage", AtkStr);
                    timeLeft = 1f;
                   // isWaitingTime = true;
                  //  currentState = TurnState.WAITING;
                  //  gameObject.SetActive(false);
                }
                break;

            case (TurnState.CHOOSEACTIONS):
                 //Debug.Log("Napisz CHOOSEACTIONS");
               // isWaitingTime = false;
                isActionTime = true;
                isMegaTime = false;
                xPos = gameObject.transform.position.x + Random.Range(3,7);
                zPos = gameObject.transform.position.z + Random.Range(3, 7);
                xPos2 = gameObject.transform.position.x + Random.Range(-10, -5);
                zPos2 = gameObject.transform.position.z + Random.Range(-10, -5);
                int directionChange = Random.Range(1, 9);
                switch (directionChange)
                {
                    case 1:
                        targetDest = new Vector3(xPos, 0, zPos);
                        break;
                    case 2:
                        targetDest = new Vector3(xPos2, 0, zPos2);
                        break;
                    case 3:
                        targetDest = new Vector3(xPos, 0, zPos2);
                        break;
                    case 4:
                        targetDest = new Vector3(xPos2, 0, zPos2);
                        break;
                    case 5:
                        targetDest = new Vector3(xPos, 0, 0);
                        break;
                    case 6:
                        targetDest = new Vector3(xPos2, 0, 0);
                        break;
                    case 7:
                        targetDest = new Vector3(0, 0, zPos);
                        break;
                    case 8:
                        targetDest = new Vector3(0, 0, zPos2);
                        break;

                                            
                }
               // targetDest = new Vector3(xPos, 0, zPos);
                agent.SetDestination(targetDest);
                anim.SetInteger("AnimControl", 1);
                
                //ChooseAction();
                //currentState = TurnState.WAITING;
    
                break;

            case (TurnState.WAITING):
                 //Debug.Log("Napisz WAITING");
                isActionTime = false;
                isMegaTime = true;
                
                //waitingTime = 1f;
               
                anim.SetInteger("AnimControl", 0);                 
                          
                if (actionDecision >27 && actionDecision < 30)
                {
                    actionTime = Random.Range(0.25f, 1f);
                    currentState = TurnState.CHOOSEACTIONS;
                }

                //else if (actionDecision < 4) 
                //{
                //    waitingTime = 1f;
                //}
                break;

            case (TurnState.ACTION):
             //   Debug.Log("Napisz ACTION");
                //StartCoroutine(TimeForAction());
                break;

            case (TurnState.DEAD):
              //  Debug.Log("Napisz DEAD");

                break;

        }

        
            
        }


    public void PlayerDetected()
    {
        Debug.Log("otrzymałem cel" + gameObject.name);
        currentState = TurnState.PROCESSING;

    }

    //void ChooseAction()
    //{

    //    HandleTurns myAttack = new HandleTurns();
    //    myAttack.Attacker = enemy.enemyName;
    //    myAttack.Type = "Enemy";
    //    myAttack.AttackersGameObject = this.gameObject;
    //    myAttack.AttackersTarget = BSM.HerosInBattle[0];
    //    BSM.CollectActions(myAttack);


    //}

    //private IEnumerator TimeForAction()
    //{

    //    if (actionStarted)
    //    {
    //        yield break;

    //    }

    //    actionStarted = true;

    //    //animate the enemy near the hero to attack
    //    Vector3 playerPosition = new Vector3(playerToAttack.transform.position.x - 7.5f, playerToAttack.transform.position.y, playerToAttack.transform.position.z);
    //    while (MoveTowardsEnemy(playerPosition))
    //    {
    //       // Debug.Log("yebac yebane krasnale");
    //        yield return null;

    //    }

    //    //wait a bit
    //    //do damage

    //    //animate back to start position

    //    //remove this performer from the list in BSM

    //    //reset BSM -> WAIT

    //    actionStarted = false;

    //    //reset this enemy state

    //    currentState = TurnState.PROCESSING;

    //}


    //private bool MoveTowardsEnemy(Vector3 target)
    //{

    //    return target != (transform.position = Vector3.MoveTowards(transform.position, target, animSpeed * Time.deltaTime));

    //}



}





