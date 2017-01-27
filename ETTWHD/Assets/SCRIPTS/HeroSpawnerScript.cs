using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSpawnerScript : MonoBehaviour {

    public GameObject[] bohater;
    public GameObject z;

    void Start()
    {

        GameObject bohaterprefab = bohater[Random.Range(0, bohater.Length)];
        z = (GameObject)Instantiate(bohaterprefab, z.transform.position, z.transform.rotation);
    }
}
