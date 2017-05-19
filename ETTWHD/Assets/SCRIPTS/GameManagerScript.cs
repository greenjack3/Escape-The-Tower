using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//namespace Completed

    using System.Collections.Generic;       //Allows us to use Lists. 
   

 public class GameManagerScript : MonoBehaviour
{        public static GameManagerScript instance = null;
        
     
        public int pupy;
        public Text PUPY;
    public float curHP;
    public float maxHP;
    public Text Hp;
    float heroHP;
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
        maxHP = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<PlayerLifeScript>().Max_Health;
        curHP = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<PlayerLifeScript>().Cur_Health;
        SetHP();
    }





        void Update()
        {
            SetPupyText();
        //curHP = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<PlayerLifeScript>().Cur_Health;
        SetHP();
    }

        void SetPupyText()
        {
            PUPY.text = /*"PUPy:"*/  pupy.ToString();
        }
        void AddPup(int PUPamount)
        {
            pupy += PUPamount;
        }
    public void hpupdate(float Cur_Health)
    {
        curHP = Cur_Health;
    }
       
        void SetHP()
    {
        //heroHP = curHP / maxHP;
        Hp.text = curHP.ToString() + '/' + maxHP.ToString();
    }
}
  
