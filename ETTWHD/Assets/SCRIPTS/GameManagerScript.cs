using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//namespace Completed

    using System.Collections.Generic;       //Allows us to use Lists. 
   

    public class GameManagerScript : MonoBehaviour
    {
        public static GameManagerScript instance = null;
        
     
        public int pupy;
        public Text PUPY;
        

        void Awake()
        {
            if (instance == null)

                instance = this;

           else if (instance != this)


                Destroy(gameObject);

            DontDestroyOnLoad(gameObject);

         }
        
        

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
            PUPY.text = /*"PUPy:"*/  pupy.ToString();
        }
        void AddPup(int PUPamount)
        {
            pupy += PUPamount;
        }

       
        
    }
  
