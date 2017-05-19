using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[System.Serializable]

public class PlayerLifeScript : MonoBehaviour {

    public float Max_Health;
    public float Cur_Health;
    public float Def;
    public Animator anim;
    public Text HealthBar;
    public CharacterMovementScript x;
    public float timer = 0.1f;
    public bool startTimer = false;
    public bool isDead;
    public float potionPower;
    void Start()
    {
        Cur_Health = Max_Health;
        anim = GetComponentInChildren<Animator>();
        x = GetComponent<CharacterMovementScript>();

        isDead = false;
        
    }

    public void Update()
    {



        PlayerDeath();

        if (startTimer == true)
        {
            timer -= Time.deltaTime;
        }

        if (timer < 0)
        {
            anim.SetInteger("AnimDwarfControl", 0);
            startTimer = false;
            timer = 0.1f;
        }

      
    }

    void CalculateDamage(float AtkStr)
    {
        float Damage = AtkStr - Def;
       // anim.SetInteger("AnimDwarfControl", 3);
        startTimer = true;
        CalculateHealth(Damage);
       

    }

    void CalculateHealth(float Damage)
    {
        Cur_Health = Cur_Health - Damage;
        GameObject.FindGameObjectWithTag("DM").SendMessage("hpupdate", Cur_Health);
        //float Calc_Health = Cur_Health / Max_Health;
       // SetHealthBar(Calc_Health);
        if (Cur_Health > 0)
        {
            anim.SetInteger("AnimDwarfControl", 3);
            startTimer = true;

        }
    }

    void PlayerDeath()
    {
        if (Cur_Health <= 0)
        {
            x.StopPlayer();
            x.BlockPlayer();
            anim.SetInteger("AnimDwarfControl", 4);
            isDead = true;
           GameObject.FindGameObjectWithTag("DM").SendMessage("resetLevel");
          GameObject Mc= GameObject.FindGameObjectWithTag("MainCamera");
            Destroy(Mc, 4f);
            Destroy(gameObject, 4f);
         
        }
    }



     void OnDestroy()
    {
        if(isDead == true)
        {
            SceneManager.LoadScene("test");
        }
   
    }

    //public void SetHealthBar(float HealthScale)
    //{
    //    HealthBar.transform.localScale = new Vector3(Mathf.Clamp(HealthScale, 0f, 1f), 1, 1);
    //}
    public void DrinkPotion()
    {

        Debug.Log("jaki smaczny napój owocowy");
        
            Cur_Health = Cur_Health + 5;
            if(Cur_Health > Max_Health)
            {
                Cur_Health = Max_Health;
            }
        GameObject.FindGameObjectWithTag("DM").SendMessage("hpupdate", Cur_Health);
    }


}


