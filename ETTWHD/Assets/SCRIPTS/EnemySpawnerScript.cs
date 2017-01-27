using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour {

    public GameObject[] przeciwnik;
    public GameObject y;

    void Start()
    {

        GameObject przeciwnikprefab = przeciwnik[Random.Range(0, przeciwnik.Length)];
        y = (GameObject)Instantiate(przeciwnikprefab, y.transform.position, y.transform.rotation);
    }
}
