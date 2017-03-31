using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        det = gameObject.GetComponent<DetectionLogic>();
       // currentState = TurnState.PROCESSING;
        //BSM = GameObject.Find("BattleManager").GetComponent<BattleStateMachine> ();
        //startPosition = transform.position;
            
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
            startTimer = false;
            timer = 0.1f;
        }

        detected = det.playerDetected;
        switch (currentState)
        {

            case (TurnState.PROCESSING):                                // chcę zapierdolić krasnoluda!
                                                                        //    Debug.Log("Napisz PROCESSING; śmierć wszystkim kransoludom yebanym!");
                Debug.Log("chce zabijać krasnale");
                timeLeft -= Time.deltaTime;
                if (timeLeft < 0)
                {
                    Debug.Log("zayebie tego krasnala " + gameObject.name);
                    anim.SetInteger("AnimControl", 2);
                    startTimer = true;
                    player.SendMessage("CalculateDamage", AtkStr);
                    timeLeft = 1f;
                    currentState = TurnState.WAITING;
                  //  gameObject.SetActive(false);
                }
                break;

            case (TurnState.CHOOSEACTIONS):
            // Debug.Log("Napisz CHOOSEACTIONS");
                //ChooseAction();
                //currentState = TurnState.WAITING;
    
                break;

            case (TurnState.WAITING):
                // Debug.Log("Napisz WAITING");
                //if (detected == true)
                //{
                //    currentState = TurnState.PROCESSING;
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





