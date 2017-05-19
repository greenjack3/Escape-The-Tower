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


    void Start()
    {
        Cur_Health = Max_Health;
        anim = GetComponentInChildren<Animator>();
        x = GetComponent<CharacterMovementScript>();
        
     
        
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

        float Calc_Health = Cur_Health / Max_Health;
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
           GameObject.FindGameObjectWithTag("DM").SendMessage("resetLevel");
          GameObject Mc= GameObject.FindGameObjectWithTag("MainCamera");
            Destroy(Mc, 4f);
            Destroy(gameObject, 4f);
         
        }
    }
     void OnDestroy()
    {
        SceneManager.LoadScene("test");
    }

    //public void SetHealthBar(float HealthScale)
    //{
    //    HealthBar.transform.localScale = new Vector3(Mathf.Clamp(HealthScale, 0f, 1f), 1, 1);
    //}



}


