using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameButtonControler : MonoBehaviour {
    public GameObject MenuPanel;
    public GameObject CharacterPanel;
    public bool menuIsActive;

    // Use this for initialization
    void Start ()
    {
        menuIsActive = false;
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
}


