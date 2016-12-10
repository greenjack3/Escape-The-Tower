using UnityEngine;
using System.Collections;

public class EnemyDustlingScript : MonoBehaviour
{
    public int str; //paramet siły
    public int dex; // parametr zręczności
    public int intt; // parametr inteligencji
    public int cha; // parametr charyzmy
    public int endu; // parametr wytrzymałości 
    private float HP; // parametr życia
    private int armor; // parametr pancerza 
    private int dmg; // parametr obrażeń 


   void start()
    {
        

    }

    void update()
    {
        

    }

    void enemystatistic()
    {
        HP = endu * 10f;
        armor = 0;
        dmg = 1; 
    }
}

