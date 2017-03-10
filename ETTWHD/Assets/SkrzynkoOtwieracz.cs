using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkrzynkoOtwieracz : MonoBehaviour
{
    public GameObject[] bronie;


    public void Otwieraj()
    {
        GameObject bron = bronie[Random.Range(0, bronie.Length)];
        GameObject instance = Instantiate(bron, transform.position, transform.rotation);
        gameObject.SetActive(false);
    }
	
}
