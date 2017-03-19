using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkrzynkoOtwieracz : MonoBehaviour
{
    public GameObject[] bronie;
    bool otwarte = false;
    float x = 0;
   

    public void Otwieraj()
    {
        
       
        GetComponentInParent<Animator>().Play("ChestAnim");
        otwarte = true;
      
        
            
       
     }
     void Update()
    {
        if (otwarte == true)
        {
            x++;
        }

      
        if (x > 62)
        {
            GameObject bron = bronie[Random.Range(0, bronie.Length)];
            GameObject instance = Instantiate(bron, transform.position, transform.rotation);
            Debug.Log("prezent");

            gameObject.SetActive(false);
           
        }
    }
}
