using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;



 public class NewLevelManagerScript : MonoBehaviour{

    
    public GameObject[] CenterRoom;
    public GameObject[] EdgeRoom;
    public GameObject[] InnerRoom;
    public GameObject[] OuterRoom;  
    public GameObject[] CenterRoomsOnScene;
    public GameObject[] EdgeRoomsOnScene;
    public GameObject[] InnerRoomsOnScene;
    public GameObject[] OuterRoomsOnScene;



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
            //instance.transform.Rotate(Vector3.up * 30f, Space.World); obracanie pokoju 
            
         }

        foreach (GameObject Room in EdgeRoomsOnScene)
        {
           GameObject EdgePrefab = EdgeRoom[Random.Range(0, EdgeRoom.Length)];
            instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
        }

        foreach (GameObject Room in InnerRoomsOnScene)
        {
            GameObject InnerPrefab = InnerRoom[Random.Range()]
        }
      
    }
    public void SetupScene(int level)
    {
        //Creates floor.
        BoardSetup();

        

    }
}
