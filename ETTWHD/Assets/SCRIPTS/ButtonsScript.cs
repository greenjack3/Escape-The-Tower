using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour {



    public GameObject image;
    public bool imageisActive = false;

    public void BackToMainMenu()
    {
        Application.Quit();
        
        //SceneManager.LoadScene("MainMenuScene");
        //Destroy(GameObject.FindGameObjectWithTag("DM"));
        //Destroy(GameObject.FindGameObjectWithTag("MainCamera"));
        //Destroy(GameObject.FindGameObjectWithTag("Player"));
    }

    public void NoteButton()
    {
        if (imageisActive == false)
        {
            image.SetActive(true);
            imageisActive = true;
        }

        else if (imageisActive == true)
        {
            image.SetActive(false);
            imageisActive = false;
        }


    }



}
