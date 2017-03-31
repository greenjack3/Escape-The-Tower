﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLifeScript : MonoBehaviour
{
    public int PUPreward;

    public float Max_Health;
    public float Cur_Health;
    public Animator Anim;

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
        EnemyDeath();
    }

    // tu uwzględniamy Def
    void CalculateDamage(float AtkStr)
    {
        float Damage = AtkStr - Def;
        CalculateHealth(Damage);
        Anim.SetInteger("AnimControl", 3);
    }

    void CalculateHealth(float Damage)
    {
        Cur_Health = Cur_Health - Damage;

        float Calc_Health = Cur_Health / Max_Health;
        SetHealthBar(Calc_Health);
    }

    void EnemyDeath()
    {
        if (Cur_Health <=0)
        {
            gameObject.SetActive(false);
            GameObject.FindGameObjectWithTag("DM").SendMessage("AddPup", PUPreward);
            GameObject.FindGameObjectWithTag("CM").SendMessage("EnemyKilled");
        }
    }

    public void SetHealthBar(float HealthScale)
    {
        HealthBar.transform.localScale = new Vector3(Mathf.Clamp(HealthScale, 0f, 1f), 1, 1);
    }
}
