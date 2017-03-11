using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Completed
{
    using System.Collections.Generic;       //Allows us to use Lists. 


    public class GameManagerScript : MonoBehaviour
    {
        public static GameManagerScript instance = null;
        
      //  private NewLevelManagerScript levelScirpt;

        //public int Level;
        public int pupy;
        public Text PUPY;
        //public int Level;


        void Awake()
        {
            if (instance == null)

                instance = this;

           else if (instance != this)


                Destroy(gameObject);

            DontDestroyOnLoad(gameObject);

           

           // levelScirpt = GetComponent<NewLevelManagerScript>();
          //  Level = levelScirpt.Level;
          //  InitGame();

        }
        
        //void InitGame()
        //{
        //    levelScirpt.SetupScene(Level);
            
         
        //}

        void Start()
        {
            SetPupyText();
            pupy = 0;
           
        }





        void Update()
        {
            SetPupyText();

        }

        void SetPupyText()
        {
            PUPY.text = "PUPy:" + pupy.ToString();
        }
        void AddPup(int PUPamount)
        {
            pupy += PUPamount;
        }
        //public void zwiekszlevel()
        //{
        //    Level++;
        //}
    }
  
}