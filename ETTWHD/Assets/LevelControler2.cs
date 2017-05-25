using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControler2 : MonoBehaviour {
    public static LevelControler2 instance = null;

    public int Level;



    public void zwiekszlevel()
    {
        Level++;
    }

    public void resetLevel()
    {
        Level = 1;
    }

    void Awake()
    {
        if (instance == null)

            instance = this;

        else if (instance != this)


            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()

    {
        if (Input.GetButtonDown("Fire2"))
        {
            zwiekszlevel();
            reload();
        }

        if (Input.GetButtonDown("Jump"))
        {
            resetLevel();
            reload();
        }

	}

    public void reload()
    {
        SceneManager.LoadScene("DDLevelCreation");
    }


}
