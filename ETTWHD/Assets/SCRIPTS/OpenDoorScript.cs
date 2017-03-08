using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoorScript : MonoBehaviour
{

    private bool Locked = true;
    public int Level;
    
    void Start()
    {
       // Level++;

    }
	void Update ()
    {
		
	}

    void Unlock()
    {
        print("*click*");
        Locked = false;
        
    }

    void TryDoor()
    {
        if (Locked)
        {
            print("Shit's locked");
        }
        if (!Locked)
        {
            print("LOAD_LVL_+1");
            GameObject.FindGameObjectWithTag("DM").SendMessage("zwiekszlevel");
            GameObject.FindGameObjectWithTag("DM").SendMessage("savH");
            SceneManager.LoadScene("test");

        }
    }
}
