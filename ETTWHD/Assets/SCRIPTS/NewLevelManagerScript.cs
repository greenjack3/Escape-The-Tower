using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;
using UnityEngine.UI;



public class NewLevelManagerScript : MonoBehaviour{

    
    public GameObject[] CenterRoom;
    public GameObject[] EdgeRoom;
    public GameObject[] InnerRoom;
    public GameObject[] OuterRoom;  
    public GameObject[] CenterRoomsOnScene;
    public GameObject[] EdgeRoomsOnScene;
    public GameObject[] InnerRoomsOnScene;
    public GameObject[] OuterRoomsOnScene;
    private Grid gridscript;
    public float rotationmodifactor;
    public int pupy;
    public Text PUPY;

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

        gridscript = GetComponent<Grid>();
     
    }
    public void SetupScene(int level)
    {
        //Creates floor.
        BoardSetup();
        Grid.Instance.GenerateGrid();
        

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
