using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

    public GameObject[] mebelki;
   public GameObject x;

    void Start()
    {
        
       GameObject mebelekprefab= mebelki[Random.Range(0, mebelki.Length)];
        x = (GameObject)Instantiate(mebelekprefab, x.transform.position, x.transform.rotation);
    }
    

}
