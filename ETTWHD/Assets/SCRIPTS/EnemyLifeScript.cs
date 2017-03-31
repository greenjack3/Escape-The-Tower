using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLifeScript : MonoBehaviour
{
    public int PUPreward;

    public float Max_Health;
    public float Cur_Health;
    public Animator Anim;
    public float timer = 0.1f;
    public bool startTimer = false;
    public float Def;

    public GameObject HealthBar;

	void Start ()
    {
        Cur_Health = Max_Health;
        //        InvokeRepeating("decreaseHealth", 1f, 1f);
        Anim = GetComponent<Animator>();
	}
	
	void Update ()
    {
        if (startTimer == true)
        {
            timer -= Time.deltaTime;
        }


        if (timer < 0)
        {
            Anim.SetInteger("AnimControl", 0);
            startTimer = false;
            timer = 0.1f;
        }
        //EnemyDeath();
    }

    // tu uwzględniamy Def
    void CalculateDamage(float AtkStr)
    {
        float Damage = AtkStr - Def;
        CalculateHealth(Damage);
       
    }

    void CalculateHealth(float Damage)
    {
        Cur_Health = Cur_Health - Damage;

        float Calc_Health = Cur_Health / Max_Health;
        SetHealthBar(Calc_Health);
        if (Cur_Health > 0)
        {
            startTimer = true;
            Anim.SetInteger("AnimControl", 3);
        }
            if (Cur_Health <= 0)
        {
            EnemyDeath();
        }
    }

    void EnemyDeath()
    {
        //if (Cur_Health <=0)
        //{
           // gameObject.SetActive(false);
            GameObject.FindGameObjectWithTag("DM").SendMessage("AddPup", PUPreward);
            GameObject.FindGameObjectWithTag("CM").SendMessage("EnemyKilled");

            Anim.SetInteger("AnimControl", 4);

            Destroy(gameObject, 1.5f);
        //}
    }

    public void SetHealthBar(float HealthScale)
    {
        HealthBar.transform.localScale = new Vector3(Mathf.Clamp(HealthScale, 0f, 1f), 1, 1);
    }
}
