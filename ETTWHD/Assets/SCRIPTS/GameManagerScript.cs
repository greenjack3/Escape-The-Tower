using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Completed
{
    using System.Collections.Generic;       //Allows us to use Lists. 


    public class GameManagerScript : MonoBehaviour
    {
        public static GameManagerScript instance = null;
        
        private NewLevelManagerScript levelScirpt;
        private int level = 1;
        public int pupy;
        public Text PUPY;
        void Awake()
        {
            if (instance == null)

                instance = this;

            else if (instance != this)


                Destroy(gameObject);

            DontDestroyOnLoad(gameObject);

           
            levelScirpt = GetComponent<NewLevelManagerScript>();

            InitGame();

        }
        
        void InitGame()
        {
            levelScirpt.SetupScene(level);
           
        }
        void Start()
        {
            SetPupyText();
            pupy = 0;
        }





        void Update()
        {
            

        }

        void SetPupyText()
        {
            PUPY.text = "PUPy:" + pupy.ToString();
        }
    }
  
}