using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatGenerator : MonoBehaviour
{
    public static CharacterStatGenerator instance = null;

    public int STR;
    public int AGI;
    public int END;
    public int INT;
   // public int CHA;

    public int MainStat;
    public int SecStat;
    public bool mainWeaponIsActive;
    public GameObject mainWeapon;
    public GameObject secondaryWeapon;
    public GameObject currentWeapon;
    public int Level;
    public LevelControler L;
    public GameObject Hand;
    //tablice broni startowych
    public GameObject[] STRWeapon;
    public GameObject[] AGIWeapon;
    public GameObject[] INTWeapon;

    // tablica dla dodatkowej broni;
    public GameObject[] SecondaryWeapon;
    void StatGenerator()
    {
        STR = Random.Range(1, 6);
        AGI = Random.Range(1, 6);
        END = Random.Range(1, 6);
        INT = Random.Range(1, 6);
        //  CHA = Random.Range(1, 6);
    
        

        MainStat = Random.Range(1, 5);
        switch (MainStat)
        {
            case 1:
                STR = STR + 5;
                print("MainStat STR");
                if(STRWeapon != null)
                    {
                    GameObject weapon = STRWeapon[Random.Range(0, STRWeapon.Length)];
                    GameObject w = Instantiate(weapon, Hand.transform.position, Hand.transform.rotation);
                    w.transform.parent = Hand.transform;
                    w.transform.Rotate(180, 0, 45);
                    mainWeapon = w;
                    // losowanie dodatkowej broni
                    GameObject weapon2 = SecondaryWeapon[Random.Range(0, SecondaryWeapon.Length)];
                    GameObject w2 = Instantiate(weapon2, Hand.transform.position, Hand.transform.rotation);
                    w2.transform.parent = Hand.transform;
                    w2.transform.Rotate(180, 0, 45);
                    secondaryWeapon = w2;

                    currentWeapon = mainWeapon;
                }
                    
               
                SecStat = Random.Range(1, 4);
                switch (SecStat)
                {
                    case 1:
                        AGI = AGI + 3;
                        print("SecStat AGI");
                        break;

                    case 2:
                        END = END + 3;
                        print("SecStat END");
                        break;

                    case 3:
                        INT = INT + 3;
                        print("SecStat INT");
                        break;

                    //case 4:
                    //    CHA = CHA + 3;
                    //    print("SecStat CHA");
                    //    break;

                }
                break;

            case 2:
                AGI = AGI + 5;
                print("MainStat AGI");
                if (AGIWeapon != null)
                {
                    GameObject weapon = AGIWeapon[Random.Range(0, AGIWeapon.Length)];
                    GameObject w = Instantiate(weapon, Hand.transform.position, Hand.transform.rotation);
                    w.transform.parent = Hand.transform;
                    w.transform.Rotate(180, 0, 45);
                    mainWeapon = w;
                    // losowanie dodatkowej broni
                    GameObject weapon2 = SecondaryWeapon[Random.Range(0, SecondaryWeapon.Length)];
                    GameObject w2 = Instantiate(weapon2, Hand.transform.position, Hand.transform.rotation);
                    w2.transform.parent = Hand.transform;
                    w2.transform.Rotate(180, 0, 45);
                    secondaryWeapon = w2;
                    currentWeapon = mainWeapon;
                }
                SecStat = Random.Range(1, 4);
                switch (SecStat)
                {
                    case 1:
                        STR = STR + 3;
                        print("SecStat STR");
                        break;

                    case 2:
                        END = END + 3;
                        print("SecStat END");
                        break;

                    case 3:
                        INT = INT + 3;
                        print("SecStat INT");
                        break;

                    //case 4:
                    //    CHA = CHA + 3;
                    //    print("SecStat CHA");
                    //    break;

                }
                break;


            case 3:
                END = END + 5;
                print("MainStat END");
                SecStat = Random.Range(1, 4);
                switch (SecStat)
                {
                    case 1:
                        STR = STR + 3;
                        print("SecStat STR");
                        if (STRWeapon != null)
                        {
                            GameObject weapon = STRWeapon[Random.Range(0, STRWeapon.Length)];
                            GameObject w = Instantiate(weapon, Hand.transform.position, Hand.transform.rotation);
                            w.transform.parent = Hand.transform;
                            w.transform.Rotate(180, 0, 45);
                            mainWeapon = w;
                            // losowanie dodatkowej broni
                            GameObject weapon2 = SecondaryWeapon[Random.Range(0, SecondaryWeapon.Length)];
                            GameObject w2 = Instantiate(weapon2, Hand.transform.position, Hand.transform.rotation);
                            w2.transform.parent = Hand.transform;
                            w2.transform.Rotate(180, 0, 45);
                            secondaryWeapon = w2;
                            currentWeapon = mainWeapon;
                        }
                        break;

                    case 2:
                        AGI = AGI + 3;
                        print("SecStat AGI");
                        if (AGIWeapon != null)
                        {
                            GameObject weapon = AGIWeapon[Random.Range(0, AGIWeapon.Length)];
                            GameObject w = Instantiate(weapon, Hand.transform.position, Hand.transform.rotation);
                            w.transform.parent = Hand.transform;
                            w.transform.Rotate(180, 0, 45);
                            mainWeapon = w;
                            // losowanie dodatkowej broni
                            GameObject weapon2 = SecondaryWeapon[Random.Range(0, SecondaryWeapon.Length)];
                            GameObject w2 = Instantiate(weapon2, Hand.transform.position, Hand.transform.rotation);
                            w2.transform.parent = Hand.transform;
                            w2.transform.Rotate(180, 0, 45);
                            secondaryWeapon = w2;
                            currentWeapon = mainWeapon;
                        }
                        break;

                    case 3:
                        INT = INT + 3;
                        print("SecStat INT");
                        if (INTWeapon != null)
                        {
                            GameObject weapon = INTWeapon[Random.Range(0, INTWeapon.Length)];
                            GameObject w = Instantiate(weapon, Hand.transform.position, Hand.transform.rotation);
                            w.transform.parent = Hand.transform;
                            w.transform.Rotate(180, 0, 45);
                            mainWeapon = w;
                            // losowanie dodatkowej broni
                            GameObject weapon2 = SecondaryWeapon[Random.Range(0, SecondaryWeapon.Length)];
                            GameObject w2 = Instantiate(weapon2, Hand.transform.position, Hand.transform.rotation);
                            w2.transform.parent = Hand.transform;
                            w2.transform.Rotate(180, 0, 45);
                            secondaryWeapon = w2;
                            currentWeapon = mainWeapon;
                        }
                        break;

                    //case 4:
                    //    CHA = CHA + 3;
                    //    print("SecStat CHA");
                    //    break;

                }
                break;

            case 4:
                INT = INT + 5;
                print("MainStat INT");
                if (INTWeapon != null)
                {
                    GameObject weapon = INTWeapon[Random.Range(0, INTWeapon.Length)];
                    GameObject w = Instantiate(weapon, Hand.transform.position, transform.rotation);

                    w.transform.parent = Hand.transform;
                    w.transform.Rotate(180, 0, 45);

                    mainWeapon = w;
                    // losowanie dodatkowej broni
                    GameObject weapon2 = SecondaryWeapon[Random.Range(0, SecondaryWeapon.Length)];
                    GameObject w2 = Instantiate(weapon2, Hand.transform.position, Hand.transform.rotation);
                    w2.transform.parent = Hand.transform;
                    w2.transform.Rotate(180, 0, 45);
                    secondaryWeapon = w2;
                    currentWeapon = mainWeapon;

                }
                SecStat = Random.Range(1, 4);
                switch (SecStat)
                {
                    case 1:
                        STR = STR + 3;
                        print("SecStat STR");
                        break;

                    case 2:
                        AGI = AGI + 3;
                        print("SecStat AGI");
                        break;

                    case 3:
                        END = END + 3;
                        print("SecStat END");
                        break;

                    //case 4:
                    //    CHA = CHA + 3;
                    //    print("SecStat CHA");
                    //    break;

                }
                break;

            //case 5:
            //    CHA = CHA +  5;
            //    print("MainStat CHA");
            //    SecStat = Random.Range(1, 5);
            //    switch (SecStat)
            //    {
            //        case 1:
            //            STR = STR + 3;
            //            print("SecStat STR");
            //            break;

            //        case 2:
            //            AGI = AGI + 3;
            //            print("SecStat AGI");
            //            break;

            //        case 3:
            //            END = END + 3;
            //            print("SecStat END");
            //            break;

            //        case 4:
            //            INT = INT + 3;
            //            print("SecStat INT");
            //            break;

            //    }
            //    break;
        }
    }

 public void Awake()
    {
        if (instance == null)

            instance = this;

        else if (instance != this)


            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        L = GameObject.FindGameObjectWithTag("DM").GetComponent<LevelControler>();
        Level = L.Level;

        //Hand = GameObject.FindGameObjectWithTag("WeaponSocket");
        //if (Level == 1)
        //{
        //    StatGenerator();
        //}

    }
    public void Start()
    {
        Hand = GameObject.FindGameObjectWithTag("WeaponSocket");
        if (Level == 1)
        {
            StatGenerator();
        }
        secondaryWeapon.SetActive(false);
        mainWeaponIsActive = true;
        Debug.Log("hahahahah");
    }

    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (mainWeaponIsActive == true)
            {
                mainWeaponIsActive = false;
            }

            else if (mainWeaponIsActive == false) 
            {
                mainWeaponIsActive = true;
            }

        }




        if(mainWeaponIsActive == false)
        {
            mainWeapon.SetActive(false);
            secondaryWeapon.SetActive(true);
            currentWeapon = secondaryWeapon;    
        }

        if(mainWeaponIsActive == true)
        {
            mainWeapon.SetActive(true);
            secondaryWeapon.SetActive(false);
            currentWeapon = mainWeapon;
        }
        //Debug.Log("update");
        //if (Input.GetButtonDown("Fire1"))
        //{

        //    Debug.Log("klikam");
        //    if (mainWeaponIsActive == true)
        //    {
        //        Debug.Log("główna broń");
        //      //  secondaryWeapon.SetActive(true);
        //        //mainWeapon.SetActive(false);
        //        //currentWeapon = secondaryWeapon;
        //        mainWeaponIsActive = false;
        //    }

        //     if (mainWeaponIsActive == false)
        //    {
        //        Debug.Log("dodatkowa broń");
        //       // mainWeapon.SetActive(true);
        //       // secondaryWeapon.SetActive(false);
        //        //currentWeapon = mainWeapon;
        //        mainWeaponIsActive = true;
        //    }
        }
    }


