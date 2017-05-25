using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwaper : MonoBehaviour {


    public void loadMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void loadGame()
    {
        SceneManager.LoadScene("test");

    }
	

    public void loadDwarf()
    {
        SceneManager.LoadScene("DD Dwarf creation");
    }
	
    public void loadLevelek()
    {
        SceneManager.LoadScene("DDLevelCreation");
    }
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("loadMainMenu"))
        {
            loadMainMenu();
            GameObject x = GameObject.FindGameObjectWithTag("DM");
            Destroy(x);
        }

       else if (Input.GetButtonDown("GAME"))
        {
            loadGame();
        }

       else if (Input.GetButtonDown("Dwarf"))
        {
            loadDwarf();

        }

      else if (Input.GetButtonDown("Levelek"))
        {
            loadLevelek();
        }
	}
}
