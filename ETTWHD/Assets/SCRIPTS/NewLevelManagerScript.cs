using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;
using UnityEngine.UI;



public class NewLevelManagerScript : MonoBehaviour {


    public GameObject[] CenterRoom;
    public GameObject[] EdgeRoom;
    public GameObject[] InnerRoom;
    public GameObject[] OuterRoom;
    public GameObject[] CenterRoomsOnScene;
    public GameObject[] EdgeRoomsOnScene;
    public GameObject[] InnerRoomsOnScene;
    public GameObject[] OuterRoomsOnScene;
    //private Grid gridscript;
    public float rotationmodifactor;
    public int pupy;
    public Text PUPY;
    public int Level;

    void BoardSetup()
    {
        // if (CenterRooms == null)
        CenterRoomsOnScene = GameObject.FindGameObjectsWithTag("CR");

        EdgeRoomsOnScene = GameObject.FindGameObjectsWithTag("ER");

        InnerRoomsOnScene = GameObject.FindGameObjectsWithTag("IR");
        OuterRoomsOnScene = GameObject.FindGameObjectsWithTag("OR");
        
        

        //choose a random floor from prefab array and prepare to instantiate it.
        GameObject CenterPrefab = null;

        //instantiate the GameObject instance usng the prefab chosen for toInstantiate at the Vector3 corresponding to current grid positon in loop, cast it to GameObject.
        GameObject instance = null;// Instantiate(CenterPrefab ) as GameObject;
        switch (Level)
        {
            case 1:

        foreach (GameObject Room in CenterRoomsOnScene)
        {
            CenterPrefab = CenterRoom[Random.Range(0, CenterRoom.Length)];
            instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);

        }

        foreach (GameObject Room in EdgeRoomsOnScene)
        {
            GameObject EdgePrefab = EdgeRoom[Random.Range(0, EdgeRoom.Length)];
            instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
            rotationmodifactor = Random.Range(0f, 9f);
            if (rotationmodifactor < 3)
            {
                instance.transform.Rotate(Vector3.up * 90f, Space.World); //obracanie pokoju 
            }

        }


        foreach (GameObject Room in InnerRoomsOnScene)
        {
            GameObject InnerPrefab = InnerRoom[Random.Range(0, InnerRoom.Length)];
            instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
            rotationmodifactor = Random.Range(0f, 9f);
            if (rotationmodifactor < 4)
            {
                instance.transform.Rotate(Vector3.up * 90f, Space.World); //obracanie pokoju 
            }

        }

        foreach (GameObject Room in OuterRoomsOnScene)
        {
            GameObject OuterPrefab = OuterRoom[Random.Range(0, OuterRoom.Length)];
            instance = (GameObject)Instantiate(OuterPrefab, Room.transform.position, Room.transform.rotation);
            rotationmodifactor = Random.Range(0f, 9f);
            if (rotationmodifactor < 5)
            {
                instance.transform.Rotate(Vector3.up * 90f, Space.World); //obracanie pokoju 
            }

        }

       break;

            case 2:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom[Random.Range(0, CenterRoom.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom[Random.Range(0, EdgeRoom.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    rotationmodifactor = Random.Range(0f, 9f);
                    if (rotationmodifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom[Random.Range(0, InnerRoom.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    rotationmodifactor = Random.Range(0f, 9f);
                    if (rotationmodifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom[Random.Range(0, OuterRoom.Length)];
                    instance = (GameObject)Instantiate(OuterPrefab, Room.transform.position, Room.transform.rotation);
                    rotationmodifactor = Random.Range(0f, 9f);
                    if (rotationmodifactor < 5)
                    {
                        instance.transform.Rotate(Vector3.up * 90f, Space.World); //obracanie pokoju 
                    }

                }
                break;

            case 3:

                break;

            case 4:

                break;

            case 5:

                break;

            case 6:

                break;

            case 7:

                break;

            case 8:

                break;

            case 9:

                break;

            case 10:

                break;

            case 11:

                break;

            case 12:

                break;

            case 13:

                break;

            case 14:

                break;

            case 15:

                break;

            case 16:

                break;

            case 17:

                break;

            case 18:

                break;

            case 19:

                break;

            case 20:

                break;

            case 21:

                break;

            case 22:

                break;

            case 23:

                break;

            case 24:

                break;

            case 25:

                break;

            case 26:

                break;

            case 27:

                break;

            case 28:

                break;

            case 29:

                break;

            case 30:

                break;

            case 31:

                break;

            case 32:

                break;

            case 33:

                break;

            case 34:

                break;

            case 35:

                break;

            case 36:

                break;

            case 37:

                break;

            case 38:

                break;

            case 39:

                break;

            case 40:

                break;

            case 41:

                break;

            case 42:

                break;

            case 43:

                break;

            case 44:

                break;

            case 45:

                break;

            case 46:

                break;

            case 47:

                break;

            case 48:

                break;

            case 49:

                break;

            case 50:

                break;



        }


    }

    public void SetupScene(int Level)
    {
        //Creates floor.
        BoardSetup();
        //Grid.Instance.GenerateGrid();
        

    }
    void Start()
    {
//        pupy = 0;
    }

    void Update()
    {
        SetPupyText();
    }
    void SetPupyText()
    { 
        PUPY.text = "PUPy:" + pupy.ToString();
    }

    void AddPup(int PUPamount)
    {
        pupy += PUPamount;
    }
}
