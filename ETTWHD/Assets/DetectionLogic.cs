using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionLogic : MonoBehaviour
{

    public float fieldOfViewDegrees;
    public float visibilityDistance;
    private Vector3 playerPosition;
    
    void Start()
    {

    }

    public bool CanSeePlayer()
    {
        RaycastHit hit;
        GameObject player = GameObject.FindWithTag("Player");
        playerPosition = player.transform.position;
        Vector3 rayDirection = player.transform.position - transform.position;

        if ((Vector3.Angle(rayDirection, transform.forward)) <= fieldOfViewDegrees * 0.5f)
        {
            if (Physics.Raycast(transform.position, rayDirection, out hit, visibilityDistance))
            {
                return (hit.transform.CompareTag("Player"));

                Debug.Log("Player Spotted");
            }
        }

        return false;
    }
}
