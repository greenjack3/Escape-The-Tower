using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;
using UnityEngine.UI;



public class NewLevelManagerScript : MonoBehaviour {

    // Tablice prefabów

    // Pokoje
    public GameObject[] CenterRoom;     // Tablica prefabów klatki schodowej dla poziomów 1-9
    public GameObject[] CenterRoom2;    // Tablica prefabów klatki schodowej dla poziomów 11-19
    public GameObject[] CenterRoom3;    // Tablica prefabów klatki schodowej dla poziomów 21-29
    public GameObject[] CenterRoom4;    // Tablica prefabów klatki schodowej dla poziomów 31-39
    public GameObject[] CenterRoom5;    // Tablica prefabów klatki schodowej dla poziomów 41-49
    public GameObject[] EdgeRoom;       // Tablica prefabów pokoi narożnych dla poziomów 1-9
    public GameObject[] EdgeRoom2;
    public GameObject[] EdgeRoom3;
    public GameObject[] EdgeRoom4;
    public GameObject[] EdgeRoom5;
    public GameObject[] InnerRoom;      // Tablica prefabów pokoi wewnętrznych dla poziomów 1-9
    public GameObject[] InnerRoom2;
    public GameObject[] InnerRoom3;
    public GameObject[] InnerRoom4;
    public GameObject[] InnerRoom5;
    public GameObject[] OuterRoom;      // Tablica prefabów pokoi zewnętrznych dla poziomów 1-9
    public GameObject[] OuterRoom2;
    public GameObject[] OuterRoom3;
    public GameObject[] OuterRoom4;
    public GameObject[] OuterRoom5;

    // Meble
    public GameObject[] Mebelki_1x1;    // Tablica prefabów mebli 1x1 dla poziomów 1-9
    public GameObject[] Mebelki_1x1_2;
    public GameObject[] Mebelki_1x1_3;
    public GameObject[] Mebelki_1x1_4;
    public GameObject[] Mebelki_1x1_5;
    public GameObject[] Mebelki_1x2;    // Tablica prefabów mebli 1x2 dla poziomów 1-9
    public GameObject[] Mebelki_1x2_2;
    public GameObject[] Mebelki_1x2_3;
    public GameObject[] Mebelki_1x2_4;
    public GameObject[] Mebelki_1x2_5;
    public GameObject[] Mebelki_1x3;    // Tablica prefabów mebli 1x3 dla poziomów 1-9
    public GameObject[] Mebelki_1x3_2;
    public GameObject[] Mebelki_1x3_3;
    public GameObject[] Mebelki_1x3_4;
    public GameObject[] Mebelki_1x3_5;
    public GameObject[] Mebelki_2x1;    // Tablica prefabów mebli 2x1 dla poziomów 1-9
    public GameObject[] Mebelki_2x1_2;
    public GameObject[] Mebelki_2x1_3;
    public GameObject[] Mebelki_2x1_4;
    public GameObject[] Mebelki_2x1_5;
    public GameObject[] Mebelki_2x2;    // Tablica prefabów mebli 2x2 dla poziomów 1-9
    public GameObject[] Mebelki_2x2_2;
    public GameObject[] Mebelki_2x2_3;
    public GameObject[] Mebelki_2x2_4;
    public GameObject[] Mebelki_2x2_5;
    public GameObject[] Mebelki_2x3;    // Tablica prefabów mebli 2x3 dla poziomów 1-9
    public GameObject[] Mebelki_2x3_2;
    public GameObject[] Mebelki_2x3_3;
    public GameObject[] Mebelki_2x3_4;
    public GameObject[] Mebelki_2x3_5;
    public GameObject[] Mebelki_3x1;    // Tablica prefabów mebli 3x1 dla poziomów 1-9
    public GameObject[] Mebelki_3x1_2;
    public GameObject[] Mebelki_3x1_3;
    public GameObject[] Mebelki_3x1_4;
    public GameObject[] Mebelki_3x1_5;
    public GameObject[] Mebelki_3x2;    // Tablica prefabów mebli 3x2 dla poziomów 1-9
    public GameObject[] Mebelki_3x2_2;
    public GameObject[] Mebelki_3x2_3;
    public GameObject[] Mebelki_3x2_4;
    public GameObject[] Mebelki_3x2_5;
    public GameObject[] Mebelki_3x3;    // Tablica prefabów mebli 3x3 dla poziomów 1-9
    public GameObject[] Mebelki_3x3_2;
    public GameObject[] Mebelki_3x3_3;
    public GameObject[] Mebelki_3x3_4;
    public GameObject[] Mebelki_3x3_5;

    // Kowadło
    public GameObject[] Kowadło;

    // Skrzynki
    public GameObject[] Skrzynia;
    public GameObject[] Skrzynia2;
    public GameObject[] Skrzynia3;
    public GameObject[] Skrzynia4;
    public GameObject[] Skrzynia5;

    // Obiekty interakatywne
    public GameObject[] Interactive;
    public GameObject[] Interactive2;
    public GameObject[] Interactive3;
    public GameObject[] Interactive4;
    public GameObject[] Interactive5;

    // Punkty świetlne 
    public GameObject[] LightSpot;
    public GameObject[] LightSpot2;
    public GameObject[] LightSpot3;
    public GameObject[] LightSpot4;
    public GameObject[] LightSpot5;

    // Przeciwnicy Melee
    public GameObject[] EnemyMelee;
    public GameObject[] EnemyMelee2;
    public GameObject[] EnemyMelee3;
    public GameObject[] EnemyMelee4;
    public GameObject[] EnemyMelee5;

    // Przeciwnicy Dist
    public GameObject[] EnemyRanged;
    public GameObject[] EnemyRanged2;
    public GameObject[] EnemyRanged3;
    public GameObject[] EnemyRanged4;
    public GameObject[] EnemyRanged5;

    // Przeciwnicy Supp
    public GameObject[] EnemySupport;
    public GameObject[] EnemySupport2;
    public GameObject[] EnemySupport3;
    public GameObject[] EnemySupport4;
    public GameObject[] EnemySupport5;


    //Tablice spawn pointów 
    public GameObject[] CenterRoomsOnScene; // Tablica spawn pointu klatki schodowej  
    public GameObject[] EdgeRoomsOnScene;   // Tablica spawn pointów pokoi narożnych 
    public GameObject[] InnerRoomsOnScene;  // Tablica spawn pointów pokoi wewnętrznych
    public GameObject[] OuterRoomsOnScene;  // Tablica spwan pointów pokoi zewnętrznych
    public GameObject[] Mebelki_1x1_OnScene;
    public GameObject[] Mebelki_1x2_OnScene;
    public GameObject[] Mebelki_1x3_OnScene;
    public GameObject[] Mebelki_2x1_OnScene;
    public GameObject[] Mebelki_2x2_OnScene;
    public GameObject[] Mebelki_2x3_OnScene;
    public GameObject[] Mebelki_3x1_OnScene;
    public GameObject[] Mebelki_3x2_OnScene;
    public GameObject[] Mebelki_3x3_OnScene;
    public GameObject[] KowadłoOnScene;
    public GameObject[] SkrzyniaOnScene;
    public GameObject[] InteractiveOnScene;
    public GameObject[] LightSpotOnScene;
    public GameObject[] EnemyMeleeOnScene;
    public GameObject[] EnemyRangedOnScene;
    public GameObject[] EnemySupportOnScene; 

    //Zmienne i inne parametry
    public Grid gridscript;
    public int RotationModifactor;
    public int BossSelector; // zmienna wybierająca bossa i jego level
    public int pupy;
    public Text PUPY;
    public int Level;

    void BoardSetup()
    {
        // if (CenterRooms == null)
        CenterRoomsOnScene = GameObject.FindGameObjectsWithTag("CR");

        EdgeRoomsOnScene = GameObject.FindGameObjectsWithTag("ER");

        InnerRoomsOnScene = GameObject.FindGameObjectsWithTag("IR");
        OuterRoomsOnScene = GameObject.FindGameObjectsWithTag("OR");
        
        

        //choose a random floor from prefab array and prepare to instantiate it.
        GameObject CenterPrefab = null;

        //instantiate the GameObject instance usng the prefab chosen for toInstantiate at the Vector3 corresponding to current grid positon in loop, cast it to GameObject.
        GameObject instance = null;// Instantiate(CenterPrefab ) as GameObject;
        switch (Level)
        {
            case 1:

        foreach (GameObject Room in CenterRoomsOnScene)
        {
            CenterPrefab = CenterRoom[Random.Range(0, CenterRoom.Length)];
            instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");
                    
                }

        foreach (GameObject Room in EdgeRoomsOnScene)
        {
            GameObject EdgePrefab = EdgeRoom[Random.Range(0, EdgeRoom.Length)];
            instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
            RotationModifactor = Random.Range(0, 4);
            if (RotationModifactor < 3)
            {
                instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
            }

        }


        foreach (GameObject Room in InnerRoomsOnScene)
        {
            GameObject InnerPrefab = InnerRoom[Random.Range(0, InnerRoom.Length)];
            instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
            RotationModifactor = Random.Range(0, 8);
            if (RotationModifactor < 4)
            {
                instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
            }

        }

        foreach (GameObject Room in OuterRoomsOnScene)
        {
            GameObject OuterPrefab = OuterRoom[Random.Range(0, OuterRoom.Length)];
            instance = (GameObject)Instantiate(OuterPrefab, Room.transform.position, Room.transform.rotation);
            RotationModifactor = Random.Range(0, 9);
            if (RotationModifactor < 5)
            {
                instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
            }

        }

                Mebelki_1x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x1");

                 foreach (GameObject Mebelek in Mebelki_1x1_OnScene)
                {
                   GameObject.FindGameObjectWithTag("pointer").SetActive(false);
            
                    GameObject MebelekPrefab = Mebelki_1x1[Random.Range(0, Mebelki_1x1.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2[Random.Range(0, Mebelki_1x2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");
               
                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3[Random.Range(0, Mebelki_1x3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1[Random.Range(0, Mebelki_2x1.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2[Random.Range(0, Mebelki_2x2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3[Random.Range(0, Mebelki_2x3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1[Random.Range(0, Mebelki_3x1.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2[Random.Range(0, Mebelki_3x2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3[Random.Range(0, Mebelki_3x3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {

                }
                 SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");
                 InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");
                 LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                
                break;

            case 2:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom[Random.Range(0, CenterRoom.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom[Random.Range(0, EdgeRoom.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 9);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom[Random.Range(0, InnerRoom.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 9);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom[Random.Range(0, OuterRoom.Length)];
                    instance = (GameObject)Instantiate(OuterPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 9);
                    if (RotationModifactor < 5)
                    {
                        instance.transform.Rotate(Vector3.up * 90f, Space.World); //obracanie pokoju 
                    }

                }

               
                break;

            case 3:

                break;

            case 4:

                break;

            case 5:

                break;

            case 6:

                break;

            case 7:

                break;

            case 8:

                break;

            case 9:

                break;

            case 10:

                break;

            case 11:

                break;

            case 12:

                break;

            case 13:

                break;

            case 14:

                break;

            case 15:

                break;

            case 16:

                break;

            case 17:

                break;

            case 18:

                break;

            case 19:

                break;

            case 20:

                break;

            case 21:

                break;

            case 22:

                break;

            case 23:

                break;

            case 24:

                break;

            case 25:

                break;

            case 26:

                break;

            case 27:

                break;

            case 28:

                break;

            case 29:

                break;

            case 30:

                break;

            case 31:

                break;

            case 32:

                break;

            case 33:

                break;

            case 34:

                break;

            case 35:

                break;

            case 36:

                break;

            case 37:

                break;

            case 38:

                break;

            case 39:

                break;

            case 40:

                break;

            case 41:

                break;

            case 42:

                break;

            case 43:

                break;

            case 44:

                break;

            case 45:

                break;

            case 46:

                break;

            case 47:

                break;

            case 48:

                break;

            case 49:

                break;

            case 50:

                break;



        }

        gridscript.GenerateGrid();

    }

   public void SpawnerPrzedmiotów()
    {
        
        
       
       
       
    }

    public void SetupScene(int Level)
    {
       
        BoardSetup();
        //SpawnerPrzedmiotów();
       
        
    }
    void Start()
    {
//        pupy = 0;
    }

    void Update()
    {
        SetPupyText();
    }
    void SetPupyText()
    { 
        PUPY.text = "PUPy:" + pupy.ToString();
    }

    void AddPup(int PUPamount)
    {
        pupy += PUPamount;
    }
}
