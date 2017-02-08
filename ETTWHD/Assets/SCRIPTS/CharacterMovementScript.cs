using UnityEngine;
using System.Collections;

public class CharacterMovementScript : MonoBehaviour
{
    private bool flag = false;

    private Vector3 endPoint;

    public float duration = 2.0f;

    private float yAxis;

    void start()
    {
        yAxis = gameObject.transform.position.y;
    }

    void Update()
    {
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

            }
        }
        if (flag && !Mathf.Approximately(gameObject.transform.position.magnitude, endPoint.magnitude))
        {
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, endPoint, 1 / (duration * (Vector3.Distance(gameObject.transform.position, endPoint))));
        }
        else if (flag && Mathf.Approximately(gameObject.transform.position.magnitude, endPoint.magnitude))
        {
            flag = false;
            Debug.Log("i am here");
        }

        if (Input.GetMouseButtonDown(1))
        {
                RaycastHit hitEnemy;
                Ray rayAttack;
                rayAttack = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(rayAttack, out hitEnemy))
                {
                    if (hitEnemy.collider.tag == "Enemy")
                    {
                        Debug.Log("HADZIA!");
                        GameObject.Find("room").SendMessage("Add100Pup");
                        hitEnemy.collider.gameObject.SetActive(false);
                    }
                }
       if (hitEnemy.collider.tag == "Exit")
            {
                Debug.Log("Radek, otwórz!");
//                GameObject.Find("room").SendMessage("Add100Pup");

            }

       if (hitEnemy.collider.tag == "Player")
            {
                Debug.Log("CZEGO?!");
//                GameObject.Find("room").SendMessage("Add100Pup");
            }


        }

    }



}
