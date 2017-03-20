using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionLogic : MonoBehaviour
{

    public float fieldOfViewDegrees;
    public float visibilityDistance;
    public Vector3 playerPosition;
    public bool playerDetected;

    void Start()
    {
        playerDetected = false;
    }

    public void CanSeePlayer()
    {
        
        RaycastHit hit;
        GameObject player = GameObject.FindWithTag("h");
        playerPosition = player.transform.position;
        Vector3 rayDirection = player.transform.position - transform.position;

        if ((Vector3.Angle(rayDirection, transform.forward)) <= fieldOfViewDegrees * 0.5f)
        {
            if (Physics.Raycast(transform.position, rayDirection, out hit, visibilityDistance))
            {

                if(hit.collider.tag == "h")
                {
                    Debug.Log("Player Spotted");
                    playerDetected = true;
                    TurnBasedCombatStateMenager.Instance.PlayerDetected();
                }

                else
                {
                    playerDetected = false;
                }

              //  Debug.Log("Player Spotted");
                    
               // return(hit.transform.CompareTag("h")) && playerDetected ==true ;

                //  Debug.Log("Player Spotted");
            }
        }
    }

    private void Update()
    {
        if(playerDetected == false)
        {
           
              CanSeePlayer();
        }
    }
}
