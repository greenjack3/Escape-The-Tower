using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]


public class EnemyBase

{

    public string enemyName;
    
    public enum EnemyType
    {
        MELEE,
        RANGED,
        SUPPORT,
        BOSS

    }

    public EnemyType enemyType;

    public float baseHP;
    public float curHP;

    public float baseATK;
    public float curATK;

    public float baseDEF;
    public float curDEF;

    public int Strenght;
    public int Agility;
    public int Inteligencce;
    public int Endurance;
    public int Charisma;

}
