using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameButtonControler : MonoBehaviour {
    public GameObject MenuPanel;
    public GameObject CharacterPanel;
    public bool menuIsActive;
    public bool characterPanelIsActive;
    // Use this for initialization
    void Start ()
    {
        menuIsActive = false;
        characterPanelIsActive = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        

    }



   public void MenuButton()
    {
        if (menuIsActive == false)
        {
            MenuPanel.SetActive(true);
            menuIsActive = true;
        }

      else  if (menuIsActive == true)
        {
            MenuPanel.SetActive(false);
            menuIsActive = false;
        }
    }


    public void CharacterButton()
    {
        if(characterPanelIsActive == false)
        {
            CharacterPanel.SetActive(true);
            characterPanelIsActive = true;
        }

        else if (characterPanelIsActive == true)
        {
            CharacterPanel.SetActive(false);
            characterPanelIsActive = false;
        }
    }

    public void exit()
    {
        Application.Quit();
    }

    public void Potion()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<PlayerLifeScript>().SendMessage("DrinkPotion");
    }
}


