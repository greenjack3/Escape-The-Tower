﻿using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class CharacterMovementScript : MonoBehaviour
{
    private bool flag = false;
    public float timer = 0.1f;
    private Vector3 endPoint;
    public bool startTimer = false;
    public float duration = 2.0f;
    float Treshold = 0.25f;
    private float yAxis;

    public float AtkStr;

    private GameObject Target;
    public GameObject mosue;
    Animator anim;

    NavMeshAgent agent;

    public bool blockInput = false;
    //public GameObject mainWeapon;
    //public GameObject secondaryWeapon;
    //public GameObject currentWeapon;
         

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        // nie wiem co to Jacuś :P
        yAxis = gameObject.transform.position.y;
        mosue = GameObject.FindGameObjectWithTag("m");
        anim = GetComponentInChildren<Animator>();
        //mainWeapon = GetComponent<CharacterStatGenerator>().mainWeapon;
        //secondaryWeapon = GetComponent<CharacterStatGenerator>().secondaryWeapon;
        //currentWeapon = mainWeapon;
        //secondaryWeapon.SetActive(false);
    

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

        if (timer < 0)
        {
            anim.SetInteger("AnimDwarfControl", 0);
            startTimer = false;
            timer = 0.1f;
        }
        float distanceToTarget = Vector3.Distance(transform.position, endPoint);
        if (distanceToTarget < Treshold)
        {
            anim.SetInteger("AnimDwarfControl", 0);
        }

        if (blockInput)
        {
            return;
        }
        // ruch
        if (Input.GetMouseButtonDown(0))
        {
            //anim.SetInteger("AnimDwarfControl", 0);
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
                // int mov = 1;
                anim.SetInteger("AnimDwarfControl", 1);
                
               


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
                    anim.SetInteger("AnimDwarfControl", 2);
                    startTimer = true;
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

        //if (Input.GetButtonDown("Swap"))
        //{
        //    if(currentWeapon = mainWeapon)
        //    {
        //        currentWeapon = secondaryWeapon;
        //        secondaryWeapon.SetActive(true);
        //        mainWeapon.SetActive(false);
        //    }

        //    else if(currentWeapon != mainWeapon)
        //    {
        //        currentWeapon = mainWeapon;
        //        mainWeapon.SetActive(true);
        //        secondaryWeapon.SetActive(false);
        //    } 
        //}
    }

    void Update()
    {

        //if(mainWeapon = null)
        //{
        //    mainWeapon = GetComponent<CharacterStatGenerator>().mainWeapon;
        //    secondaryWeapon = GetComponent<CharacterStatGenerator>().secondaryWeapon;
        //    currentWeapon = mainWeapon;
        //    secondaryWeapon.SetActive(false);

        //}
        // liczenie ataku
        // Calc_AtkStr();
        HandleInput();
       // transform.LookAt(mosue.transform);
       
        //if (flag && !Mathf.Approximately(gameObject.transform.position.magnitude, endPoint.magnitude))
        //{
        //    gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, endPoint, 1 / (duration * (Vector3.Distance(gameObject.transform.position, endPoint))));
        //}

        if(startTimer == true)
        {
            timer -= Time.deltaTime;
        }



    }

    void Calc_AtkStr()
    {
        // Tu policzcie sobie ile ma AtkStr :)
    }

   
}
