using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PlayerLifeScript : MonoBehaviour {

    public float Max_Health;
    public float Cur_Health;
    public float Def;

    public GameObject HealthBar;

    void Start()
    {
        Cur_Health = Max_Health;
    }

    public void Update()
    {
        PlayerDeath();
    }

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
    }

    void PlayerDeath()
    {
        if (Cur_Health <= 0)
        {
            Destroy(gameObject);
       
            GameObject.FindGameObjectWithTag("CM").SendMessage("EnemyKilled");
        }
    }

    public void SetHealthBar(float HealthScale)
    {
        HealthBar.transform.localScale = new Vector3(Mathf.Clamp(HealthScale, 0f, 1f), 1, 1);
    }



}


