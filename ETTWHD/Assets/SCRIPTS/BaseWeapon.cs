using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseWeapon: MonoBehaviour
{
    public string Name;

    public int BaseAtk;
    public int BaseRng;
    public int APCost;

    public int BonusSTR;
    public int BonusAGI;
    public int BonusEND;
    public int BonusINT;
    // public int BonusCHA;
    public bool isGenerated;

    public GameObject[] AxeHandle;
    public GameObject[] AxeBlade;
    public GameObject[] DaggerHandle;
    public GameObject[] DaggerBlade;
    public GameObject[] WandHandle;
    public GameObject[] WandTip;

    public enum AtkType
    {
        Melee,
        Magic,
        Ranged,
    }
    public enum WeaponType
    {
       Axe,
       Dagger,
       Wand,
       Sword,
       FistWeapon,
       Hammer,
       Staff,
       Bow,
       CrossBow,



    }

    public enum WeaponRarity
    {
        common,
        uncommon,
        rare,
        epic,
        ancestral
    }

    public enum WeaponMaterial
    {
        Copper,
        Iron,
        Steel,
        DarkSteel,
        Mithril,

    }
    public WeaponType weaponType;
    public WeaponRarity weaponRarity;
    public AtkType atkType;
    public WeaponMaterial weaponMaterial;

    public void WeaponGenerator()
    {
        if(isGenerated == true)
        {
            int AT = Random.Range(0, 2);

            switch (AT)
            {
                case 0:
                    atkType = 0;
                    int WT = Random.Range(0, 2);
                    switch (WT)
                    {
                        case 0:
                            weaponType = 0;
                            weaponRarity = 0;
                            weaponMaterial = 0;
                            Name = "axe";
                            BaseAtk = Random.Range(10, 16);
                            BaseRng = 1;
                            APCost = 1;
                            if (AxeHandle != null)
                            {
                                GameObject axe = Instantiate(AxeHandle[Random.Range(0, AxeHandle.Length)], transform.position, transform.rotation);
                                axe.transform.parent = gameObject.transform;
                                if (AxeBlade != null)
                                {

                                    GameObject bladeSocket = GameObject.FindGameObjectWithTag("Blade");
                                    GameObject blade = Instantiate(AxeBlade[Random.Range(0, AxeBlade.Length)], bladeSocket.transform.position, bladeSocket.transform.rotation);
                                    blade.transform.parent = axe.transform;
                                }
                            }
                            break;

                        case 1:
                            weaponType = WeaponType.Dagger;
                            weaponRarity = 0;
                            weaponMaterial = 0;
                            Name = "dagger";
                            BaseAtk = Random.Range(10, 16);
                            BaseRng = 1;
                            APCost = 1;
                            if (DaggerHandle != null)
                            {
                                GameObject dagger = Instantiate(DaggerHandle[Random.Range(0, DaggerHandle.Length)], transform.position, transform.rotation);
                                dagger.transform.parent = gameObject.transform;
                                if (DaggerBlade != null)
                                {
                                  GameObject  bladeSocket = GameObject.FindGameObjectWithTag("Blade");
                                 GameObject   blade = Instantiate(DaggerBlade[Random.Range(0, DaggerBlade.Length)], bladeSocket.transform.position, bladeSocket.transform.rotation);
                                    blade.transform.parent = dagger.transform;
                                }
                            }
                            break;
                    }
                    break;

                case 1:
                    atkType = AtkType.Magic;
                    WT = 2;
                    switch (WT)
                    {
                        case 2:
                            weaponType = WeaponType.Wand;
                            weaponRarity = 0;
                            weaponMaterial = 0;
                            Name = "wand";
                            BaseAtk = Random.Range(10, 16);
                            BaseRng = 7;
                            APCost = 1;
                            if (WandHandle != null)
                            {
                                GameObject wand = Instantiate(WandHandle[Random.Range(0, WandHandle.Length)], transform.position, transform.rotation);
                                wand.transform.parent = gameObject.transform;
                                if (WandTip != null)
                                {
                                    GameObject bladeSocket = GameObject.FindGameObjectWithTag("Blade");
                                    GameObject Tip = Instantiate(WandTip[Random.Range(0, WandTip.Length)], bladeSocket.transform.position, bladeSocket.transform.rotation);
                                    Tip.transform.parent = wand.transform;
                                }
                            }
                            break;
                    }
                    break;
            }
        }
    }

    public void Awake()
    {
        WeaponGenerator();
    }
}
