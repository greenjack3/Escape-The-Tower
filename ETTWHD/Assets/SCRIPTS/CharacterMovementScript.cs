using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class CharacterMovementScript : MonoBehaviour
{
    private bool flag = false;

    private Vector3 endPoint;

    public float duration = 2.0f;

    private float yAxis;

    public float AtkStr;

    private GameObject Target;
    public GameObject mosue;

    NavMeshAgent agent;

    public bool blockInput = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        // nie wiem co to Jacuś :P
        yAxis = gameObject.transform.position.y;
        mosue = GameObject.FindGameObjectWithTag("m");
    }


    public void StopPlayer()
    {
        agent.Stop();
        agent.ResetPath();
        agent.Resume();
    }
    public void BlockPlayer()
    {
        blockInput = true;
    }

    public void StopBlockPlayer()
    {
        blockInput = false;
    }

    void HandleInput()
    {
        if (blockInput)
        {
            return;
        }
        // ruch
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                flag = true;
                endPoint = hit.point;
                endPoint.y = yAxis;
                GameObject h = GameObject.FindGameObjectWithTag("Player");
                agent.SetDestination(endPoint);

            }
            else if (flag && Mathf.Approximately(gameObject.transform.position.magnitude, endPoint.magnitude))
            {
                flag = false;
                Debug.Log("i am here");
            }
        }
        // atak/interakcja
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit RightClickRay;
            Ray rayAttack;
            rayAttack = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(rayAttack, out RightClickRay))
            {
                Debug.Log(RightClickRay.collider.gameObject.name);
                if (RightClickRay.collider.tag == "Enemy")
                {
                    Debug.Log("HADZIA!");
                    //                        GameObject.Find(RightClickRay.collider.gameObject.name).SendMessage("CalculateDamage", AtkStr);
                    GameObject Target = RightClickRay.collider.transform.gameObject;
                    Target.SendMessage("CalculateDamage", AtkStr);

                    //                        GameObject.Find("room").SendMessage("Add100Pup");
                    //                        hitEnemy.collider.gameObject.SetActive(false);
                }
            }
            if (RightClickRay.collider.tag == "Exit")
            {
                GameObject.FindGameObjectWithTag("Exit").SendMessage("TryDoor");
            }

            if (RightClickRay.collider.tag == "Player")
            {
                Debug.Log("CZEGO?!");
                //                GameObject.Find("odbiorca").SendMessage("nazwa voida");
            }

            if (RightClickRay.collider.tag == "CHEST")
            {
                Debug.Log("otwieraj sie ");
                GameObject skrzynia = RightClickRay.collider.transform.gameObject;
                skrzynia.SendMessage("Otwieraj");
            }

            if (RightClickRay.collider.tag == "Item")
            {
                GameObject przedmiot = RightClickRay.collider.transform.gameObject;
                Debug.Log("przedmiot:" + przedmiot.name);
                przedmiot.gameObject.SetActive(false);
            }
        }
    }

    void Update()
    {
        // liczenie ataku
       // Calc_AtkStr();
        HandleInput();
       // transform.LookAt(mosue.transform);
       
        //if (flag && !Mathf.Approximately(gameObject.transform.position.magnitude, endPoint.magnitude))
        //{
        //    gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, endPoint, 1 / (duration * (Vector3.Distance(gameObject.transform.position, endPoint))));
        //}





    }

    void Calc_AtkStr()
    {
        // Tu policzcie sobie ile ma AtkStr :)
    }
}
