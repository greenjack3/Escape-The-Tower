using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class BaseItem
{
    public string Name;

    public bool isStackable;
  

    public int BonusSTR;
    public int BonusAGI;
    public int BonusEND;
    public int BonusINT;
    public int BonusCHA;


    public enum ItemType
    {
        Ring,
        HpPotion,
        StatPotion
    }

    public enum ItemRarity
    {
        common,
        uncommon,
        rare,
        epic,
        ancestral
    }

    public ItemType itemType;
    public ItemRarity itemRarity;
}

