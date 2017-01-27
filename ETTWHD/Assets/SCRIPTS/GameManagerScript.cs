using UnityEngine;
using System.Collections;

namespace Completed
{
    using System.Collections.Generic;       //Allows us to use Lists. 


    public class GameManagerScript : MonoBehaviour
    {
        public static GameManagerScript instance = null;
        
        private NewLevelManagerScript levelScirpt;
        private int level = 1;

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
        void Update()
        {

        }
    }
  
}