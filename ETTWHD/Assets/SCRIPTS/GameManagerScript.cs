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
    public int STR;
    public int AGI;
    public int END;
    public int INT;

    public Text strVal;
    public Text agiVal;
    public Text endVal;
    public Text intVal;

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
        GetStats();
        SetStats();

    }





        void Update()
        {
            SetPupyText();
        //curHP = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<PlayerLifeScript>().Cur_Health;
        SetHP();
        if(STR == 0)
        {
            GetStats();
            SetStats();
        }


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


    public void GetStats()
    {
      STR = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterStatGenerator>().STR;
        AGI = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterStatGenerator>().AGI; 
        END = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterStatGenerator>().END; 
        INT = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterStatGenerator>().INT; 
}

    public void SetStats()
    {
      strVal.text = STR.ToString();
     agiVal.text = AGI.ToString();
     endVal.text = END.ToString();
     intVal.text = INT.ToString();
}
}

  
