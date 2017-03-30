using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class BaseArmor
{
    public string Name;

    public int BaseDef;
   

    public int BonusSTR;
    public int BonusAGI;
    public int BonusEND;
    public int BonusINT;
    public int BonusCHA;

    public enum ArmorType
    {
        smallShield,
        Shield,
        bigShield,
        Robe,
        LightArmor,
        MidArmor,
        HeavyArmor


    }

    public enum ArmorRarity
    {
        common,
        uncommon,
        rare,
        epic,
        ancestral
    }
    public ArmorType armorType;
    public ArmorRarity armorRarity;
}
