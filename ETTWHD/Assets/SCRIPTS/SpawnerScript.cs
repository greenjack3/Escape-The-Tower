using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

    public GameObject[] mebelki;


    void mebelekspawner()
    {
        
       GameObject mebelekprefab= mebelki[Random.Range(0, mebelki.Length)];
     // GameObject  instance = (GameObject)Instantiate(mebelekprefab, instance.transform.position, Room.transform.rotation);
    }
    

}
