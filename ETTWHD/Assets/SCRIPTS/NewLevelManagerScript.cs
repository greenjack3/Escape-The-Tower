using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;



 public class NewLevelManagerScript : MonoBehaviour{

    public GameObject Exit;
    public GameObject[] CenterRoom;
    public GameObject[] CornerRoom;
    public GameObject[] OuterRoom;
    public GameObject[] InnerRoom;
    public GameObject[] CenterRooms;



    void BoardSetup()
    {
        if (CenterRooms == null)
        CenterRooms = GameObject.FindGameObjectsWithTag("CR");
       
                //choose a random floor from prefab array and prepare to instantiate it.
                GameObject CenterPrefab = CenterRoom[Random.Range(0, CenterRoom.Length)];

        //instantiate the GameObject instance usng the prefab chosen for toInstantiate at the Vector3 corresponding to current grid positon in loop, cast it to GameObject.
         GameObject instance = Instantiate(CenterPrefab ) as GameObject;
        /*   foreach (GameObject Room in CenterRooms)
        {
                 Instantiate(CenterPrefab);
         }
      */
    }
    public void SetupScene(int level)
    {
        //Creates floor.
        BoardSetup();

        

    }
}
