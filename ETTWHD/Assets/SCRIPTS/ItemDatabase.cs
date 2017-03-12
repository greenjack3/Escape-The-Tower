using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> InventoryDat = new List<Item>();




     void Start()
    {
        foreach (Item i in InventoryDat)
        {
            i.ItemAmount = PlayerPrefs.GetInt(i.ItemName);
        }
    }


    void FixedUpdate()
    {
        foreach (Item i in InventoryDat)
        {
            if (i.ItemAmount > 0)
            {
                i.itemSlot.SetActive(true);
            }

            else
            {
                i.itemSlot.SetActive(false);
            }

            if (i.ItemAmount != PlayerPrefs.GetInt(i.ItemName))
            {
                PlayerPrefs.SetInt(i.ItemName, i.ItemAmount);
                print("saved: " + i.ItemName);
            }
        }
    }

}
