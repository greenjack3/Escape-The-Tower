using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseWeapon
{
    public string Name;

    public int BaseAtk;
    public int BaseRng;

    public int BonusSTR;
    public int BonusAGI;
    public int BonusEND;
    public int BonusINT;
    public int BonusCHA;

    public enum WeaponType
    {
        Sword,
        Axe,
        Hammer,
        Wand,
        Gun,
        Staff,
        Dagger,
        Bow

    }

    public enum WeaponRarity
    {
        common,
        uncommon,
        rare,
        epic,
        ancestral
    }
    public WeaponType weaponType;
    public WeaponRarity weaponRarity;    
	
}
