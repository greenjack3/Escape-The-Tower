using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyCountScript : MonoBehaviour
{
    public float Requirement;

    private GameObject[] EnemyTotal;
    private float Enemy_Max;
    private float Enemy_Cur;
    private float Enemy_Calc;

    private bool EnemiesCounted = false;

    public Text EnemyCounter;

    void Start ()
    {
//        EnemyTotal = GameObject.FindGameObjectsWithTag("Enemy");
//        Enemy_Max = EnemyTotal.Length;
        Enemy_Cur = 0;
        //        EnemyCalculate();
        EnemyCounter = GameObject.FindGameObjectWithTag("EnemyTekst").GetComponent<Text>();
    }
	
	void Update ()
    {
        if (!EnemiesCounted)
        {
            EnemyTotal = GameObject.FindGameObjectsWithTag("Enemy");
            EnemiesCounted = true;
        }
        Enemy_Max = EnemyTotal.Length;
//        Enemy_Cur = 0;
        EnemyCalculate();

        print(Enemy_Cur + "/" + Enemy_Calc + "/" + Enemy_Max);
    }

    void EnemyKilled()
    {
        Enemy_Cur += 1;
        EnemyCalculate();
    }

    void EnemyCalculate()
    {
        Enemy_Calc = Enemy_Cur / Enemy_Max * 100;
        EnemyCounter.text = "Pokonani Przeciwnicy: " + (int)Enemy_Calc + "%";
        if (Enemy_Calc>= Requirement)
        {
            GameObject.FindGameObjectWithTag("Exit").SendMessage("Unlock");

        }
    }


}
