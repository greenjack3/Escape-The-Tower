using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkrzynkoOtwieracz : MonoBehaviour
{
    public GameObject[] bronie;
    bool otwarte = false;
    float x = 0;
    bool spawned = false;
    public GameObject Wep;
    public float amplitude = 0.5f;
    public float frequency = 1f;
    //public GameObject particle; 
    // Position Storage Variables
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();
    public void Otwieraj()
    {
        
       
        GetComponent<Animator>().Play("ChestAnim");
        GetComponentInChildren<ParticleSystem>().Play();
        otwarte = true;
      
        
            
       
     }

    public void SpawnItem()
    {
        GameObject bron = bronie[Random.Range(0, bronie.Length)];
        
        Wep = Instantiate(bron, transform.position, transform.rotation);
        Wep.transform.position = transform.position + Vector3.up*2;
        //Wep.transform.Rotate(90, 0,0);
        posOffset = Wep.transform.position;
        Debug.Log("prezent");
        spawned = true;

    }
     void Update()
    {
        //Wep.transform.Rotate(90, 0, 45 * Time.deltaTime);
        if (spawned == false)
        {

            if (otwarte == true)
            {
                x++;
            }


            if (x > 20)
            {
                SpawnItem();


                // gameObject.SetActive(false);

            }
        }
        if(spawned == true)
        {
            Wep.transform.Rotate(0, 90 * Time.deltaTime, 0 );
            tempPos = posOffset;
            tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

            Wep.transform.position = tempPos;
        }
    }
}
