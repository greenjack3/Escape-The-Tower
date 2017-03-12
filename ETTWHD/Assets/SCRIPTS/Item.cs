using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string ItemName;
    public int ItemAmount;
    public GameObject itemSlot;

    public Item(string iName, int iAmount, GameObject iSlot)
    {
        iName = ItemName;
        iAmount = ItemAmount;
        iSlot = itemSlot;
    }

	
}
