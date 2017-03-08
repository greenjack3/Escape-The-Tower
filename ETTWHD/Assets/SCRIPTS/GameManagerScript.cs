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

        //public int Level;
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
            levelScirpt.SetupScene();
            
         
        }

        void Start()
        {
            SetPupyText();
            pupy = 0;
           // Level++;
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