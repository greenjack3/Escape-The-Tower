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

    // Tablice poziomów Bossa
    public GameObject[] BoosLevel1_1; // Tablica poziomów dla 1 bossa na poziome 10
    public GameObject[] BoosLevel1_2;
    public GameObject[] BoosLevel1_3;
    public GameObject[] BoosLevel2_1;
    public GameObject[] BoosLevel2_2;
    public GameObject[] BoosLevel2_3;
    public GameObject[] BoosLevel3_1;
    public GameObject[] BoosLevel3_2;
    public GameObject[] BoosLevel3_3;
    public GameObject[] BoosLevel4_1;
    public GameObject[] BoosLevel4_2;
    public GameObject[] BoosLevel4_3;
    public GameObject[] BoosLevel5_1;
    public GameObject[] BoosLevel5_2;
    public GameObject[] BoosLevel5_3;



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
    public GameObject BossOnScene;

    //Prefaby Bossa 
    public GameObject BossPrefab1_1;
    public GameObject BossPrefab1_2;
    public GameObject BossPrefab1_3;
    public GameObject BossPrefab2_1;
    public GameObject BossPrefab2_2;
    public GameObject BossPrefab2_3;
    public GameObject BossPrefab3_1;
    public GameObject BossPrefab3_2;
    public GameObject BossPrefab3_3;
    public GameObject BossPrefab4_1;
    public GameObject BossPrefab4_2;
    public GameObject BossPrefab4_3;
    public GameObject BossPrefab5_1;
    public GameObject BossPrefab5_2;
    public GameObject BossPrefab5_3;

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
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                 SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia[Random.Range(0, Skrzynia.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                 InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive[Random.Range(0, Interactive.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot[Random.Range(0, LightSpot.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                
                break;

            case 2:
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
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia[Random.Range(0, Skrzynia.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive[Random.Range(0, Interactive.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot[Random.Range(0, LightSpot.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }


                break;

            case 3:
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
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia[Random.Range(0, Skrzynia.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive[Random.Range(0, Interactive.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot[Random.Range(0, LightSpot.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }
                break;

            case 4:
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
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia[Random.Range(0, Skrzynia.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive[Random.Range(0, Interactive.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot[Random.Range(0, LightSpot.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }
                break;

            case 5:
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
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia[Random.Range(0, Skrzynia.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive[Random.Range(0, Interactive.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot[Random.Range(0, LightSpot.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }
                break;

            case 6:
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
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia[Random.Range(0, Skrzynia.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive[Random.Range(0, Interactive.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot[Random.Range(0, LightSpot.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }
                break;

            case 7:
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
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia[Random.Range(0, Skrzynia.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive[Random.Range(0, Interactive.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot[Random.Range(0, LightSpot.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }
                break;

            case 8:
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
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia[Random.Range(0, Skrzynia.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive[Random.Range(0, Interactive.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot[Random.Range(0, LightSpot.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }
                break;

            case 9:
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
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia[Random.Range(0, Skrzynia.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive[Random.Range(0, Interactive.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot[Random.Range(0, LightSpot.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }
                break;

            case 10:
                BossSelector = Random.Range(1, 4);

                switch (BossSelector)
                {
                    case 1:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                     GameObject Center = GameObject.FindGameObjectWithTag("CR");
                        GameObject LevelPrefab = BoosLevel1_1[Random.Range(0, BoosLevel1_1.Length)];
                        instance = Instantiate(LevelPrefab, Center.transform.position, Center.transform.rotation);

                        break;

                    case 2:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject Center2 = GameObject.FindGameObjectWithTag("CR");
                        GameObject LevelPrefab2 = BoosLevel1_2[Random.Range(0, BoosLevel1_2.Length)];
                        instance = Instantiate(LevelPrefab2, Center2.transform.position, Center2.transform.rotation);

                        break;

                    case 3:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject Center3 = GameObject.FindGameObjectWithTag("CR");
                        GameObject LevelPrefab3 = BoosLevel1_3[Random.Range(0, BoosLevel1_3.Length)];
                        instance = Instantiate(LevelPrefab3, Center3.transform.position, Center3.transform.rotation);

                        break;


                }

                break;

            case 11:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom2[Random.Range(0, CenterRoom2.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom2[Random.Range(0, EdgeRoom2.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom2[Random.Range(0, InnerRoom2.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom2[Random.Range(0, OuterRoom2.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_2[Random.Range(0, Mebelki_1x1_2.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_2[Random.Range(0, Mebelki_1x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_2[Random.Range(0, Mebelki_1x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_2[Random.Range(0, Mebelki_2x1_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_2[Random.Range(0, Mebelki_2x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_2[Random.Range(0, Mebelki_2x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_2[Random.Range(0, Mebelki_3x1_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_2[Random.Range(0, Mebelki_3x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_2[Random.Range(0, Mebelki_3x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia2[Random.Range(0, Skrzynia2.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive2[Random.Range(0, Interactive2.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot2[Random.Range(0, LightSpot2.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 12:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom2[Random.Range(0, CenterRoom2.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom2[Random.Range(0, EdgeRoom2.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom2[Random.Range(0, InnerRoom2.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom2[Random.Range(0, OuterRoom2.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_2[Random.Range(0, Mebelki_1x1_2.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_2[Random.Range(0, Mebelki_1x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_2[Random.Range(0, Mebelki_1x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_2[Random.Range(0, Mebelki_2x1_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_2[Random.Range(0, Mebelki_2x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_2[Random.Range(0, Mebelki_2x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_2[Random.Range(0, Mebelki_3x1_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_2[Random.Range(0, Mebelki_3x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_2[Random.Range(0, Mebelki_3x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia2[Random.Range(0, Skrzynia2.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive2[Random.Range(0, Interactive2.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot2[Random.Range(0, LightSpot2.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 13:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom2[Random.Range(0, CenterRoom2.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom2[Random.Range(0, EdgeRoom2.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom2[Random.Range(0, InnerRoom2.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom2[Random.Range(0, OuterRoom2.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_2[Random.Range(0, Mebelki_1x1_2.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_2[Random.Range(0, Mebelki_1x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_2[Random.Range(0, Mebelki_1x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_2[Random.Range(0, Mebelki_2x1_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_2[Random.Range(0, Mebelki_2x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_2[Random.Range(0, Mebelki_2x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_2[Random.Range(0, Mebelki_3x1_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_2[Random.Range(0, Mebelki_3x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_2[Random.Range(0, Mebelki_3x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia2[Random.Range(0, Skrzynia2.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive2[Random.Range(0, Interactive2.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot2[Random.Range(0, LightSpot2.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 14:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom2[Random.Range(0, CenterRoom2.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom2[Random.Range(0, EdgeRoom2.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom2[Random.Range(0, InnerRoom2.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom2[Random.Range(0, OuterRoom2.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_2[Random.Range(0, Mebelki_1x1_2.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_2[Random.Range(0, Mebelki_1x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_2[Random.Range(0, Mebelki_1x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_2[Random.Range(0, Mebelki_2x1_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_2[Random.Range(0, Mebelki_2x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_2[Random.Range(0, Mebelki_2x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_2[Random.Range(0, Mebelki_3x1_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_2[Random.Range(0, Mebelki_3x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_2[Random.Range(0, Mebelki_3x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia2[Random.Range(0, Skrzynia2.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive2[Random.Range(0, Interactive2.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot2[Random.Range(0, LightSpot2.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 15:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom2[Random.Range(0, CenterRoom2.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom2[Random.Range(0, EdgeRoom2.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom2[Random.Range(0, InnerRoom2.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom2[Random.Range(0, OuterRoom2.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_2[Random.Range(0, Mebelki_1x1_2.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_2[Random.Range(0, Mebelki_1x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_2[Random.Range(0, Mebelki_1x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_2[Random.Range(0, Mebelki_2x1_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_2[Random.Range(0, Mebelki_2x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_2[Random.Range(0, Mebelki_2x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_2[Random.Range(0, Mebelki_3x1_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_2[Random.Range(0, Mebelki_3x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_2[Random.Range(0, Mebelki_3x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia2[Random.Range(0, Skrzynia2.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive2[Random.Range(0, Interactive2.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot2[Random.Range(0, LightSpot2.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 16:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom2[Random.Range(0, CenterRoom2.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom2[Random.Range(0, EdgeRoom2.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom2[Random.Range(0, InnerRoom2.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom2[Random.Range(0, OuterRoom2.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_2[Random.Range(0, Mebelki_1x1_2.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_2[Random.Range(0, Mebelki_1x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_2[Random.Range(0, Mebelki_1x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_2[Random.Range(0, Mebelki_2x1_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_2[Random.Range(0, Mebelki_2x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_2[Random.Range(0, Mebelki_2x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_2[Random.Range(0, Mebelki_3x1_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_2[Random.Range(0, Mebelki_3x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_2[Random.Range(0, Mebelki_3x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia2[Random.Range(0, Skrzynia2.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive2[Random.Range(0, Interactive2.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot2[Random.Range(0, LightSpot2.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 17:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom2[Random.Range(0, CenterRoom2.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom2[Random.Range(0, EdgeRoom2.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom2[Random.Range(0, InnerRoom2.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom2[Random.Range(0, OuterRoom2.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_2[Random.Range(0, Mebelki_1x1_2.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_2[Random.Range(0, Mebelki_1x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_2[Random.Range(0, Mebelki_1x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_2[Random.Range(0, Mebelki_2x1_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_2[Random.Range(0, Mebelki_2x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_2[Random.Range(0, Mebelki_2x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_2[Random.Range(0, Mebelki_3x1_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_2[Random.Range(0, Mebelki_3x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_2[Random.Range(0, Mebelki_3x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia2[Random.Range(0, Skrzynia2.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive2[Random.Range(0, Interactive2.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot2[Random.Range(0, LightSpot2.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 18:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom2[Random.Range(0, CenterRoom2.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom2[Random.Range(0, EdgeRoom2.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom2[Random.Range(0, InnerRoom2.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom2[Random.Range(0, OuterRoom2.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_2[Random.Range(0, Mebelki_1x1_2.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_2[Random.Range(0, Mebelki_1x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_2[Random.Range(0, Mebelki_1x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_2[Random.Range(0, Mebelki_2x1_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_2[Random.Range(0, Mebelki_2x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_2[Random.Range(0, Mebelki_2x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_2[Random.Range(0, Mebelki_3x1_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_2[Random.Range(0, Mebelki_3x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_2[Random.Range(0, Mebelki_3x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia2[Random.Range(0, Skrzynia2.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive2[Random.Range(0, Interactive2.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot2[Random.Range(0, LightSpot2.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 19:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom2[Random.Range(0, CenterRoom2.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom2[Random.Range(0, EdgeRoom2.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom2[Random.Range(0, InnerRoom2.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom2[Random.Range(0, OuterRoom2.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_2[Random.Range(0, Mebelki_1x1_2.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_2[Random.Range(0, Mebelki_1x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_2[Random.Range(0, Mebelki_1x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_2[Random.Range(0, Mebelki_2x1_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_2[Random.Range(0, Mebelki_2x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_2[Random.Range(0, Mebelki_2x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_2[Random.Range(0, Mebelki_3x1_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_2[Random.Range(0, Mebelki_3x2_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_2[Random.Range(0, Mebelki_3x3_2.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia2[Random.Range(0, Skrzynia2.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive2[Random.Range(0, Interactive2.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot2[Random.Range(0, LightSpot2.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 20:
                BossSelector = Random.Range(1, 4);

                switch (BossSelector)
                {
                    case 1:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject Center = GameObject.FindGameObjectWithTag("CR");
                        GameObject LevelPrefab = BoosLevel2_1[Random.Range(0, BoosLevel2_1.Length)];
                        instance = Instantiate(LevelPrefab, Center.transform.position, Center.transform.rotation);

                        break;

                    case 2:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject Center2 = GameObject.FindGameObjectWithTag("CR");
                        GameObject LevelPrefab2 = BoosLevel2_2[Random.Range(0, BoosLevel2_2.Length)];
                        instance = Instantiate(LevelPrefab2, Center2.transform.position, Center2.transform.rotation);

                        break;

                    case 3:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject Center3 = GameObject.FindGameObjectWithTag("CR");
                        GameObject LevelPrefab3 = BoosLevel2_3[Random.Range(0, BoosLevel2_3.Length)];
                        instance = Instantiate(LevelPrefab3, Center3.transform.position, Center3.transform.rotation);

                        break;


                }

                break;

            case 21:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom3[Random.Range(0, CenterRoom3.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom3[Random.Range(0, EdgeRoom3.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom3[Random.Range(0, InnerRoom3.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom3[Random.Range(0, OuterRoom3.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_3[Random.Range(0, Mebelki_1x1_3.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_3[Random.Range(0, Mebelki_1x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_3[Random.Range(0, Mebelki_1x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_3[Random.Range(0, Mebelki_2x1_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_3[Random.Range(0, Mebelki_2x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_3[Random.Range(0, Mebelki_2x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_3[Random.Range(0, Mebelki_3x1_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_3[Random.Range(0, Mebelki_3x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_3[Random.Range(0, Mebelki_3x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia3[Random.Range(0, Skrzynia3.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive3[Random.Range(0, Interactive3.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot3[Random.Range(0, LightSpot3.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 22:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom3[Random.Range(0, CenterRoom3.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom3[Random.Range(0, EdgeRoom3.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom3[Random.Range(0, InnerRoom3.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom3[Random.Range(0, OuterRoom3.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_3[Random.Range(0, Mebelki_1x1_3.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_3[Random.Range(0, Mebelki_1x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_3[Random.Range(0, Mebelki_1x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_3[Random.Range(0, Mebelki_2x1_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_3[Random.Range(0, Mebelki_2x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_3[Random.Range(0, Mebelki_2x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_3[Random.Range(0, Mebelki_3x1_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_3[Random.Range(0, Mebelki_3x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_3[Random.Range(0, Mebelki_3x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia3[Random.Range(0, Skrzynia3.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive3[Random.Range(0, Interactive3.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot3[Random.Range(0, LightSpot3.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 23:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom3[Random.Range(0, CenterRoom3.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom3[Random.Range(0, EdgeRoom3.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom3[Random.Range(0, InnerRoom3.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom3[Random.Range(0, OuterRoom3.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_3[Random.Range(0, Mebelki_1x1_3.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_3[Random.Range(0, Mebelki_1x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_3[Random.Range(0, Mebelki_1x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_3[Random.Range(0, Mebelki_2x1_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_3[Random.Range(0, Mebelki_2x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_3[Random.Range(0, Mebelki_2x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_3[Random.Range(0, Mebelki_3x1_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_3[Random.Range(0, Mebelki_3x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_3[Random.Range(0, Mebelki_3x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia3[Random.Range(0, Skrzynia3.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive3[Random.Range(0, Interactive3.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot3[Random.Range(0, LightSpot3.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 24:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom3[Random.Range(0, CenterRoom3.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom3[Random.Range(0, EdgeRoom3.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom3[Random.Range(0, InnerRoom3.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom3[Random.Range(0, OuterRoom3.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_3[Random.Range(0, Mebelki_1x1_3.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_3[Random.Range(0, Mebelki_1x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_3[Random.Range(0, Mebelki_1x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_3[Random.Range(0, Mebelki_2x1_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_3[Random.Range(0, Mebelki_2x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_3[Random.Range(0, Mebelki_2x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_3[Random.Range(0, Mebelki_3x1_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_3[Random.Range(0, Mebelki_3x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_3[Random.Range(0, Mebelki_3x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia3[Random.Range(0, Skrzynia3.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive3[Random.Range(0, Interactive3.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot3[Random.Range(0, LightSpot3.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 25:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom3[Random.Range(0, CenterRoom3.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom3[Random.Range(0, EdgeRoom3.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom3[Random.Range(0, InnerRoom3.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom3[Random.Range(0, OuterRoom3.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_3[Random.Range(0, Mebelki_1x1_3.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_3[Random.Range(0, Mebelki_1x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_3[Random.Range(0, Mebelki_1x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_3[Random.Range(0, Mebelki_2x1_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_3[Random.Range(0, Mebelki_2x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_3[Random.Range(0, Mebelki_2x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_3[Random.Range(0, Mebelki_3x1_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_3[Random.Range(0, Mebelki_3x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_3[Random.Range(0, Mebelki_3x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia3[Random.Range(0, Skrzynia3.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive3[Random.Range(0, Interactive3.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot3[Random.Range(0, LightSpot3.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 26:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom3[Random.Range(0, CenterRoom3.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom3[Random.Range(0, EdgeRoom3.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom3[Random.Range(0, InnerRoom3.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom3[Random.Range(0, OuterRoom3.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_3[Random.Range(0, Mebelki_1x1_3.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_3[Random.Range(0, Mebelki_1x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_3[Random.Range(0, Mebelki_1x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_3[Random.Range(0, Mebelki_2x1_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_3[Random.Range(0, Mebelki_2x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_3[Random.Range(0, Mebelki_2x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_3[Random.Range(0, Mebelki_3x1_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_3[Random.Range(0, Mebelki_3x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_3[Random.Range(0, Mebelki_3x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia3[Random.Range(0, Skrzynia3.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive3[Random.Range(0, Interactive3.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot3[Random.Range(0, LightSpot3.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 27:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom3[Random.Range(0, CenterRoom3.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom3[Random.Range(0, EdgeRoom3.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom3[Random.Range(0, InnerRoom3.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom3[Random.Range(0, OuterRoom3.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_3[Random.Range(0, Mebelki_1x1_3.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_3[Random.Range(0, Mebelki_1x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_3[Random.Range(0, Mebelki_1x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_3[Random.Range(0, Mebelki_2x1_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_3[Random.Range(0, Mebelki_2x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_3[Random.Range(0, Mebelki_2x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_3[Random.Range(0, Mebelki_3x1_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_3[Random.Range(0, Mebelki_3x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_3[Random.Range(0, Mebelki_3x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia3[Random.Range(0, Skrzynia3.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive3[Random.Range(0, Interactive3.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot3[Random.Range(0, LightSpot3.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 28:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom3[Random.Range(0, CenterRoom3.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom3[Random.Range(0, EdgeRoom3.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom3[Random.Range(0, InnerRoom3.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom3[Random.Range(0, OuterRoom3.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_3[Random.Range(0, Mebelki_1x1_3.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_3[Random.Range(0, Mebelki_1x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_3[Random.Range(0, Mebelki_1x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_3[Random.Range(0, Mebelki_2x1_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_3[Random.Range(0, Mebelki_2x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_3[Random.Range(0, Mebelki_2x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_3[Random.Range(0, Mebelki_3x1_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_3[Random.Range(0, Mebelki_3x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_3[Random.Range(0, Mebelki_3x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia3[Random.Range(0, Skrzynia3.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive3[Random.Range(0, Interactive3.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot3[Random.Range(0, LightSpot3.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 29:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom3[Random.Range(0, CenterRoom3.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom3[Random.Range(0, EdgeRoom3.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom3[Random.Range(0, InnerRoom3.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom3[Random.Range(0, OuterRoom3.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_3[Random.Range(0, Mebelki_1x1_3.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_3[Random.Range(0, Mebelki_1x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_3[Random.Range(0, Mebelki_1x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_3[Random.Range(0, Mebelki_2x1_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_3[Random.Range(0, Mebelki_2x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_3[Random.Range(0, Mebelki_2x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_3[Random.Range(0, Mebelki_3x1_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_3[Random.Range(0, Mebelki_3x2_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_3[Random.Range(0, Mebelki_3x3_3.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia3[Random.Range(0, Skrzynia3.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive3[Random.Range(0, Interactive3.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot3[Random.Range(0, LightSpot3.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 30:
                BossSelector = Random.Range(1, 4);

                switch (BossSelector)
                {
                    case 1:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject Center = GameObject.FindGameObjectWithTag("CR");
                        GameObject LevelPrefab = BoosLevel3_1[Random.Range(0, BoosLevel3_1.Length)];
                        instance = Instantiate(LevelPrefab, Center.transform.position, Center.transform.rotation);

                        break;

                    case 2:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject Center2 = GameObject.FindGameObjectWithTag("CR");
                        GameObject LevelPrefab2 = BoosLevel3_2[Random.Range(0, BoosLevel3_2.Length)];
                        instance = Instantiate(LevelPrefab2, Center2.transform.position, Center2.transform.rotation);

                        break;

                    case 3:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject Center3 = GameObject.FindGameObjectWithTag("CR");
                        GameObject LevelPrefab3 = BoosLevel3_3[Random.Range(0, BoosLevel3_3.Length)];
                        instance = Instantiate(LevelPrefab3, Center3.transform.position, Center3.transform.rotation);

                        break;


                }

                break;

            case 31:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom4[Random.Range(0, CenterRoom4.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom4[Random.Range(0, EdgeRoom4.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom4[Random.Range(0, InnerRoom4.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom4[Random.Range(0, OuterRoom4.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_4[Random.Range(0, Mebelki_1x1_4.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_4[Random.Range(0, Mebelki_1x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_4[Random.Range(0, Mebelki_1x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_4[Random.Range(0, Mebelki_2x1_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_4[Random.Range(0, Mebelki_2x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_4[Random.Range(0, Mebelki_2x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_4[Random.Range(0, Mebelki_3x1_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_4[Random.Range(0, Mebelki_3x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_4[Random.Range(0, Mebelki_3x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia4[Random.Range(0, Skrzynia4.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive4[Random.Range(0, Interactive4.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot4[Random.Range(0, LightSpot4.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 32:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom4[Random.Range(0, CenterRoom4.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom4[Random.Range(0, EdgeRoom4.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom4[Random.Range(0, InnerRoom4.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom4[Random.Range(0, OuterRoom4.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_4[Random.Range(0, Mebelki_1x1_4.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_4[Random.Range(0, Mebelki_1x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_4[Random.Range(0, Mebelki_1x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_4[Random.Range(0, Mebelki_2x1_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_4[Random.Range(0, Mebelki_2x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_4[Random.Range(0, Mebelki_2x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_4[Random.Range(0, Mebelki_3x1_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_4[Random.Range(0, Mebelki_3x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_4[Random.Range(0, Mebelki_3x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia4[Random.Range(0, Skrzynia4.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive4[Random.Range(0, Interactive4.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot4[Random.Range(0, LightSpot4.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 33:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom4[Random.Range(0, CenterRoom4.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom4[Random.Range(0, EdgeRoom4.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom4[Random.Range(0, InnerRoom4.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom4[Random.Range(0, OuterRoom4.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_4[Random.Range(0, Mebelki_1x1_4.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_4[Random.Range(0, Mebelki_1x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_4[Random.Range(0, Mebelki_1x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_4[Random.Range(0, Mebelki_2x1_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_4[Random.Range(0, Mebelki_2x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_4[Random.Range(0, Mebelki_2x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_4[Random.Range(0, Mebelki_3x1_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_4[Random.Range(0, Mebelki_3x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_4[Random.Range(0, Mebelki_3x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia4[Random.Range(0, Skrzynia4.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive4[Random.Range(0, Interactive4.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot4[Random.Range(0, LightSpot4.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 34:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom4[Random.Range(0, CenterRoom4.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom4[Random.Range(0, EdgeRoom4.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom4[Random.Range(0, InnerRoom4.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom4[Random.Range(0, OuterRoom4.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_4[Random.Range(0, Mebelki_1x1_4.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_4[Random.Range(0, Mebelki_1x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_4[Random.Range(0, Mebelki_1x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_4[Random.Range(0, Mebelki_2x1_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_4[Random.Range(0, Mebelki_2x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_4[Random.Range(0, Mebelki_2x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_4[Random.Range(0, Mebelki_3x1_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_4[Random.Range(0, Mebelki_3x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_4[Random.Range(0, Mebelki_3x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia4[Random.Range(0, Skrzynia4.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive4[Random.Range(0, Interactive4.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot4[Random.Range(0, LightSpot4.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 35:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom4[Random.Range(0, CenterRoom4.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom4[Random.Range(0, EdgeRoom4.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom4[Random.Range(0, InnerRoom4.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom4[Random.Range(0, OuterRoom4.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_4[Random.Range(0, Mebelki_1x1_4.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_4[Random.Range(0, Mebelki_1x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_4[Random.Range(0, Mebelki_1x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_4[Random.Range(0, Mebelki_2x1_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_4[Random.Range(0, Mebelki_2x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_4[Random.Range(0, Mebelki_2x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_4[Random.Range(0, Mebelki_3x1_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_4[Random.Range(0, Mebelki_3x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_4[Random.Range(0, Mebelki_3x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia4[Random.Range(0, Skrzynia4.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive4[Random.Range(0, Interactive4.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot4[Random.Range(0, LightSpot4.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 36:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom4[Random.Range(0, CenterRoom4.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom4[Random.Range(0, EdgeRoom4.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom4[Random.Range(0, InnerRoom4.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom4[Random.Range(0, OuterRoom4.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_4[Random.Range(0, Mebelki_1x1_4.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_4[Random.Range(0, Mebelki_1x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_4[Random.Range(0, Mebelki_1x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_4[Random.Range(0, Mebelki_2x1_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_4[Random.Range(0, Mebelki_2x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_4[Random.Range(0, Mebelki_2x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_4[Random.Range(0, Mebelki_3x1_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_4[Random.Range(0, Mebelki_3x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_4[Random.Range(0, Mebelki_3x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia4[Random.Range(0, Skrzynia4.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive4[Random.Range(0, Interactive4.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot4[Random.Range(0, LightSpot4.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 37:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom4[Random.Range(0, CenterRoom4.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom4[Random.Range(0, EdgeRoom4.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom4[Random.Range(0, InnerRoom4.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom4[Random.Range(0, OuterRoom4.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_4[Random.Range(0, Mebelki_1x1_4.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_4[Random.Range(0, Mebelki_1x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_4[Random.Range(0, Mebelki_1x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_4[Random.Range(0, Mebelki_2x1_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_4[Random.Range(0, Mebelki_2x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_4[Random.Range(0, Mebelki_2x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_4[Random.Range(0, Mebelki_3x1_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_4[Random.Range(0, Mebelki_3x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_4[Random.Range(0, Mebelki_3x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia4[Random.Range(0, Skrzynia4.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive4[Random.Range(0, Interactive4.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot4[Random.Range(0, LightSpot4.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 38:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom4[Random.Range(0, CenterRoom4.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom4[Random.Range(0, EdgeRoom4.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom4[Random.Range(0, InnerRoom4.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom4[Random.Range(0, OuterRoom4.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_4[Random.Range(0, Mebelki_1x1_4.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_4[Random.Range(0, Mebelki_1x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_4[Random.Range(0, Mebelki_1x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_4[Random.Range(0, Mebelki_2x1_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_4[Random.Range(0, Mebelki_2x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_4[Random.Range(0, Mebelki_2x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_4[Random.Range(0, Mebelki_3x1_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_4[Random.Range(0, Mebelki_3x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_4[Random.Range(0, Mebelki_3x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia4[Random.Range(0, Skrzynia4.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive4[Random.Range(0, Interactive4.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot4[Random.Range(0, LightSpot4.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 39:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom4[Random.Range(0, CenterRoom4.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom4[Random.Range(0, EdgeRoom4.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom4[Random.Range(0, InnerRoom4.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom4[Random.Range(0, OuterRoom4.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_4[Random.Range(0, Mebelki_1x1_4.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_4[Random.Range(0, Mebelki_1x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_4[Random.Range(0, Mebelki_1x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_4[Random.Range(0, Mebelki_2x1_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_4[Random.Range(0, Mebelki_2x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_4[Random.Range(0, Mebelki_2x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_4[Random.Range(0, Mebelki_3x1_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_4[Random.Range(0, Mebelki_3x2_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_4[Random.Range(0, Mebelki_3x3_4.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia4[Random.Range(0, Skrzynia4.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive4[Random.Range(0, Interactive4.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot4[Random.Range(0, LightSpot4.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 40:
                BossSelector = Random.Range(1, 4);

                switch (BossSelector)
                {
                    case 1:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject Center = GameObject.FindGameObjectWithTag("CR");
                        GameObject LevelPrefab = BoosLevel4_1[Random.Range(0, BoosLevel4_1.Length)];
                        instance = Instantiate(LevelPrefab, Center.transform.position, Center.transform.rotation);

                        break;

                    case 2:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject Center2 = GameObject.FindGameObjectWithTag("CR");
                        GameObject LevelPrefab2 = BoosLevel4_2[Random.Range(0, BoosLevel4_2.Length)];
                        instance = Instantiate(LevelPrefab2, Center2.transform.position, Center2.transform.rotation);

                        break;

                    case 3:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject Center3 = GameObject.FindGameObjectWithTag("CR");
                        GameObject LevelPrefab3 = BoosLevel4_3[Random.Range(0, BoosLevel4_3.Length)];
                        instance = Instantiate(LevelPrefab3, Center3.transform.position, Center3.transform.rotation);

                        break;


                }

                break;

            case 41:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom5[Random.Range(0, CenterRoom5.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom5[Random.Range(0, EdgeRoom5.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom5[Random.Range(0, InnerRoom5.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom5[Random.Range(0, OuterRoom5.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_5[Random.Range(0, Mebelki_1x1_5.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_5[Random.Range(0, Mebelki_1x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_5[Random.Range(0, Mebelki_1x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_5[Random.Range(0, Mebelki_2x1_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_5[Random.Range(0, Mebelki_2x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_5[Random.Range(0, Mebelki_2x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_5[Random.Range(0, Mebelki_3x1_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_5[Random.Range(0, Mebelki_3x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_5[Random.Range(0, Mebelki_3x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia5[Random.Range(0, Skrzynia5.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive5[Random.Range(0, Interactive5.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot5[Random.Range(0, LightSpot5.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 42:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom5[Random.Range(0, CenterRoom5.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom5[Random.Range(0, EdgeRoom5.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom5[Random.Range(0, InnerRoom5.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom5[Random.Range(0, OuterRoom5.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_5[Random.Range(0, Mebelki_1x1_5.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_5[Random.Range(0, Mebelki_1x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_5[Random.Range(0, Mebelki_1x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_5[Random.Range(0, Mebelki_2x1_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_5[Random.Range(0, Mebelki_2x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_5[Random.Range(0, Mebelki_2x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_5[Random.Range(0, Mebelki_3x1_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_5[Random.Range(0, Mebelki_3x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_5[Random.Range(0, Mebelki_3x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia5[Random.Range(0, Skrzynia5.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive5[Random.Range(0, Interactive5.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot5[Random.Range(0, LightSpot5.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 43:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom5[Random.Range(0, CenterRoom5.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom5[Random.Range(0, EdgeRoom5.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom5[Random.Range(0, InnerRoom5.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom5[Random.Range(0, OuterRoom5.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_5[Random.Range(0, Mebelki_1x1_5.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_5[Random.Range(0, Mebelki_1x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_5[Random.Range(0, Mebelki_1x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_5[Random.Range(0, Mebelki_2x1_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_5[Random.Range(0, Mebelki_2x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_5[Random.Range(0, Mebelki_2x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_5[Random.Range(0, Mebelki_3x1_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_5[Random.Range(0, Mebelki_3x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_5[Random.Range(0, Mebelki_3x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia5[Random.Range(0, Skrzynia5.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive5[Random.Range(0, Interactive5.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot5[Random.Range(0, LightSpot5.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 44:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom5[Random.Range(0, CenterRoom5.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom5[Random.Range(0, EdgeRoom5.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom5[Random.Range(0, InnerRoom5.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom5[Random.Range(0, OuterRoom5.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_5[Random.Range(0, Mebelki_1x1_5.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_5[Random.Range(0, Mebelki_1x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_5[Random.Range(0, Mebelki_1x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_5[Random.Range(0, Mebelki_2x1_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_5[Random.Range(0, Mebelki_2x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_5[Random.Range(0, Mebelki_2x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_5[Random.Range(0, Mebelki_3x1_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_5[Random.Range(0, Mebelki_3x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_5[Random.Range(0, Mebelki_3x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia5[Random.Range(0, Skrzynia5.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive5[Random.Range(0, Interactive5.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot5[Random.Range(0, LightSpot5.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 45:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom5[Random.Range(0, CenterRoom5.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom5[Random.Range(0, EdgeRoom5.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom5[Random.Range(0, InnerRoom5.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom5[Random.Range(0, OuterRoom5.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_5[Random.Range(0, Mebelki_1x1_5.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_5[Random.Range(0, Mebelki_1x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_5[Random.Range(0, Mebelki_1x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_5[Random.Range(0, Mebelki_2x1_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_5[Random.Range(0, Mebelki_2x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_5[Random.Range(0, Mebelki_2x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_5[Random.Range(0, Mebelki_3x1_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_5[Random.Range(0, Mebelki_3x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_5[Random.Range(0, Mebelki_3x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia5[Random.Range(0, Skrzynia5.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive5[Random.Range(0, Interactive5.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot5[Random.Range(0, LightSpot5.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 46:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom5[Random.Range(0, CenterRoom5.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom5[Random.Range(0, EdgeRoom5.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom5[Random.Range(0, InnerRoom5.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom5[Random.Range(0, OuterRoom5.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_5[Random.Range(0, Mebelki_1x1_5.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_5[Random.Range(0, Mebelki_1x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_5[Random.Range(0, Mebelki_1x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_5[Random.Range(0, Mebelki_2x1_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_5[Random.Range(0, Mebelki_2x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_5[Random.Range(0, Mebelki_2x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_5[Random.Range(0, Mebelki_3x1_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_5[Random.Range(0, Mebelki_3x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_5[Random.Range(0, Mebelki_3x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia5[Random.Range(0, Skrzynia5.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive5[Random.Range(0, Interactive5.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot5[Random.Range(0, LightSpot5.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 47:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom5[Random.Range(0, CenterRoom5.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom5[Random.Range(0, EdgeRoom5.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom5[Random.Range(0, InnerRoom5.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom5[Random.Range(0, OuterRoom5.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_5[Random.Range(0, Mebelki_1x1_5.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_5[Random.Range(0, Mebelki_1x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_5[Random.Range(0, Mebelki_1x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_5[Random.Range(0, Mebelki_2x1_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_5[Random.Range(0, Mebelki_2x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_5[Random.Range(0, Mebelki_2x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_5[Random.Range(0, Mebelki_3x1_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_5[Random.Range(0, Mebelki_3x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_5[Random.Range(0, Mebelki_3x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia5[Random.Range(0, Skrzynia5.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive5[Random.Range(0, Interactive5.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot5[Random.Range(0, LightSpot5.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 48:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom5[Random.Range(0, CenterRoom5.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom5[Random.Range(0, EdgeRoom5.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom5[Random.Range(0, InnerRoom5.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom5[Random.Range(0, OuterRoom5.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_5[Random.Range(0, Mebelki_1x1_5.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_5[Random.Range(0, Mebelki_1x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_5[Random.Range(0, Mebelki_1x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_5[Random.Range(0, Mebelki_2x1_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_5[Random.Range(0, Mebelki_2x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_5[Random.Range(0, Mebelki_2x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_5[Random.Range(0, Mebelki_3x1_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_5[Random.Range(0, Mebelki_3x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_5[Random.Range(0, Mebelki_3x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia5[Random.Range(0, Skrzynia5.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive5[Random.Range(0, Interactive5.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot5[Random.Range(0, LightSpot5.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 49:
                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom5[Random.Range(0, CenterRoom5.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam");

                }

                foreach (GameObject Room in EdgeRoomsOnScene)
                {
                    GameObject EdgePrefab = EdgeRoom5[Random.Range(0, EdgeRoom5.Length)];
                    instance = (GameObject)Instantiate(EdgePrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 4);
                    if (RotationModifactor < 3)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }


                foreach (GameObject Room in InnerRoomsOnScene)
                {
                    GameObject InnerPrefab = InnerRoom5[Random.Range(0, InnerRoom5.Length)];
                    instance = (GameObject)Instantiate(InnerPrefab, Room.transform.position, Room.transform.rotation);
                    RotationModifactor = Random.Range(0, 8);
                    if (RotationModifactor < 4)
                    {
                        instance.transform.Rotate(Vector3.up * 90f * RotationModifactor, Space.World); //obracanie pokoju 
                    }

                }

                foreach (GameObject Room in OuterRoomsOnScene)
                {
                    GameObject OuterPrefab = OuterRoom5[Random.Range(0, OuterRoom5.Length)];
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

                    GameObject MebelekPrefab = Mebelki_1x1_5[Random.Range(0, Mebelki_1x1_5.Length)];
                    instance = (GameObject)Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x2");

                foreach (GameObject Mebelek in Mebelki_1x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x2_5[Random.Range(0, Mebelki_1x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_1x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp1x3");

                foreach (GameObject Mebelek in Mebelki_1x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_1x3_5[Random.Range(0, Mebelki_1x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x1");

                foreach (GameObject Mebelek in Mebelki_2x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x1_5[Random.Range(0, Mebelki_2x1_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x2");

                foreach (GameObject Mebelek in Mebelki_2x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x2_5[Random.Range(0, Mebelki_2x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_2x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp2x3");

                foreach (GameObject Mebelek in Mebelki_2x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_2x3_5[Random.Range(0, Mebelki_2x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x1_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x1");

                foreach (GameObject Mebelek in Mebelki_3x1_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x1_5[Random.Range(0, Mebelki_3x1_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x2_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x2");

                foreach (GameObject Mebelek in Mebelki_3x2_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x2_5[Random.Range(0, Mebelki_3x2_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                Mebelki_3x3_OnScene = GameObject.FindGameObjectsWithTag("MebelkiSp3x3");

                foreach (GameObject Mebelek in Mebelki_3x3_OnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject MebelekPrefab = Mebelki_3x3_5[Random.Range(0, Mebelki_3x3_5.Length)];
                    instance = Instantiate(MebelekPrefab, Mebelek.transform.position, Mebelek.transform.rotation);
                }

                KowadłoOnScene = GameObject.FindGameObjectsWithTag("Anvil");

                foreach (GameObject Kowadełko in KowadłoOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject KowadłoPrefab = Kowadło[Random.Range(0, Kowadło.Length)];
                    instance = Instantiate(KowadłoPrefab, Kowadełko.transform.position, Kowadełko.transform.rotation);
                }

                SkrzyniaOnScene = GameObject.FindGameObjectsWithTag("Chest");

                foreach (GameObject skrzyneczka in SkrzyniaOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject SkrzynkaPrefab = Skrzynia5[Random.Range(0, Skrzynia5.Length)];
                    instance = Instantiate(SkrzynkaPrefab, skrzyneczka.transform.position, skrzyneczka.transform.rotation);
                }

                InteractiveOnScene = GameObject.FindGameObjectsWithTag("Interactive");

                foreach (GameObject IA in InteractiveOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject InterActivePrefab = Interactive5[Random.Range(0, Interactive5.Length)];
                    instance = Instantiate(InterActivePrefab, IA.transform.position, IA.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot5[Random.Range(0, LightSpot5.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;

            case 50:
                BossSelector = Random.Range(1, 4);

                switch (BossSelector)
                {
                    case 1:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject Center = GameObject.FindGameObjectWithTag("CR");
                        GameObject LevelPrefab = BoosLevel5_1[Random.Range(0, BoosLevel5_1.Length)];
                        instance = Instantiate(LevelPrefab, Center.transform.position, Center.transform.rotation);

                        break;

                    case 2:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject Center2 = GameObject.FindGameObjectWithTag("CR");
                        GameObject LevelPrefab2 = BoosLevel5_2[Random.Range(0, BoosLevel5_2.Length)];
                        instance = Instantiate(LevelPrefab2, Center2.transform.position, Center2.transform.rotation);

                        break;

                    case 3:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject Center3 = GameObject.FindGameObjectWithTag("CR");
                        GameObject LevelPrefab3 = BoosLevel5_3[Random.Range(0, BoosLevel5_3.Length)];
                        instance = Instantiate(LevelPrefab3, Center3.transform.position, Center3.transform.rotation);

                        break;


                }

                break;



        }

        gridscript.GenerateGrid();

    }

   public void EnemySpawner()
    {

        switch (Level)
        {
            case 1:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee[Random.Range(0, EnemyMelee.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged[Random.Range(0, EnemyRanged.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }
                
                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport[Random.Range(0, EnemySupport.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 2:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee[Random.Range(0, EnemyMelee.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged[Random.Range(0, EnemyRanged.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport[Random.Range(0, EnemySupport.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 3:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee[Random.Range(0, EnemyMelee.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged[Random.Range(0, EnemyRanged.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport[Random.Range(0, EnemySupport.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 4:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee[Random.Range(0, EnemyMelee.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged[Random.Range(0, EnemyRanged.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport[Random.Range(0, EnemySupport.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 5:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee[Random.Range(0, EnemyMelee.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged[Random.Range(0, EnemyRanged.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport[Random.Range(0, EnemySupport.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 6:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee[Random.Range(0, EnemyMelee.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged[Random.Range(0, EnemyRanged.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport[Random.Range(0, EnemySupport.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 7:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee[Random.Range(0, EnemyMelee.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged[Random.Range(0, EnemyRanged.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport[Random.Range(0, EnemySupport.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 8:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee[Random.Range(0, EnemyMelee.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged[Random.Range(0, EnemyRanged.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport[Random.Range(0, EnemySupport.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 9:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee[Random.Range(0, EnemyMelee.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged[Random.Range(0, EnemyRanged.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport[Random.Range(0, EnemySupport.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 10:
                BossOnScene = GameObject.FindGameObjectWithTag("Boss");
              
                switch (BossSelector)
                    
                {
                    case 1:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject instance = Instantiate(BossPrefab1_1, BossOnScene.transform.position, BossOnScene.transform.rotation);
                        break;
                    case 2:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject instance2 = Instantiate(BossPrefab1_2, BossOnScene.transform.position, BossOnScene.transform.rotation);
                        break;
                    case 3:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject instance3 = Instantiate(BossPrefab1_3, BossOnScene.transform.position, BossOnScene.transform.rotation);
                        break;
                }
                break;
            case 11:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee2[Random.Range(0, EnemyMelee2.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged2[Random.Range(0, EnemyRanged2.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport2[Random.Range(0, EnemySupport2.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 12:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee2[Random.Range(0, EnemyMelee2.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged2[Random.Range(0, EnemyRanged2.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport2[Random.Range(0, EnemySupport2.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 13:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee2[Random.Range(0, EnemyMelee2.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged2[Random.Range(0, EnemyRanged2.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport2[Random.Range(0, EnemySupport2.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 14:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee2[Random.Range(0, EnemyMelee2.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged2[Random.Range(0, EnemyRanged2.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport2[Random.Range(0, EnemySupport2.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 15:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee2[Random.Range(0, EnemyMelee2.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged2[Random.Range(0, EnemyRanged2.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport2[Random.Range(0, EnemySupport2.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 16:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee2[Random.Range(0, EnemyMelee2.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged2[Random.Range(0, EnemyRanged2.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport2[Random.Range(0, EnemySupport2.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 17:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee2[Random.Range(0, EnemyMelee2.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged2[Random.Range(0, EnemyRanged2.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport2[Random.Range(0, EnemySupport2.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 18:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee2[Random.Range(0, EnemyMelee2.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged2[Random.Range(0, EnemyRanged2.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport2[Random.Range(0, EnemySupport2.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 19:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee2[Random.Range(0, EnemyMelee2.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged2[Random.Range(0, EnemyRanged2.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport2[Random.Range(0, EnemySupport2.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 20:
                BossOnScene = GameObject.FindGameObjectWithTag("Boss");

                switch (BossSelector)

                {
                    case 1:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject instance = Instantiate(BossPrefab2_1, BossOnScene.transform.position, BossOnScene.transform.rotation);
                        break;
                    case 2:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject instance2 = Instantiate(BossPrefab2_2, BossOnScene.transform.position, BossOnScene.transform.rotation);
                        break;
                    case 3:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject instance3 = Instantiate(BossPrefab2_3, BossOnScene.transform.position, BossOnScene.transform.rotation);
                        break;
                }

                break;
            case 21:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee3[Random.Range(0, EnemyMelee3.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged3[Random.Range(0, EnemyRanged3.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport3[Random.Range(0, EnemySupport3.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 22:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee3[Random.Range(0, EnemyMelee3.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged3[Random.Range(0, EnemyRanged3.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport3[Random.Range(0, EnemySupport3.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 23:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee3[Random.Range(0, EnemyMelee3.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged3[Random.Range(0, EnemyRanged3.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport3[Random.Range(0, EnemySupport3.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 24:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee3[Random.Range(0, EnemyMelee3.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged3[Random.Range(0, EnemyRanged3.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport3[Random.Range(0, EnemySupport3.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 25:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee3[Random.Range(0, EnemyMelee3.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged3[Random.Range(0, EnemyRanged3.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport3[Random.Range(0, EnemySupport3.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 26:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee3[Random.Range(0, EnemyMelee3.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged3[Random.Range(0, EnemyRanged3.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport3[Random.Range(0, EnemySupport3.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 27:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee3[Random.Range(0, EnemyMelee3.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged3[Random.Range(0, EnemyRanged3.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport3[Random.Range(0, EnemySupport3.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 28:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee3[Random.Range(0, EnemyMelee3.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged3[Random.Range(0, EnemyRanged3.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport3[Random.Range(0, EnemySupport3.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 29:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee3[Random.Range(0, EnemyMelee3.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged3[Random.Range(0, EnemyRanged3.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport3[Random.Range(0, EnemySupport3.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 30:
                BossOnScene = GameObject.FindGameObjectWithTag("Boss");

                switch (BossSelector)

                {
                    case 1:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject instance = Instantiate(BossPrefab3_1, BossOnScene.transform.position, BossOnScene.transform.rotation);
                        break;
                    case 2:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject instance2 = Instantiate(BossPrefab3_2, BossOnScene.transform.position, BossOnScene.transform.rotation);
                        break;
                    case 3:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject instance3 = Instantiate(BossPrefab3_3, BossOnScene.transform.position, BossOnScene.transform.rotation);
                        break;
                }

                break;
            case 31:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee4[Random.Range(0, EnemyMelee4.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged4[Random.Range(0, EnemyRanged4.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport4[Random.Range(0, EnemySupport4.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 32:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee4[Random.Range(0, EnemyMelee4.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged4[Random.Range(0, EnemyRanged4.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport4[Random.Range(0, EnemySupport4.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 33:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee4[Random.Range(0, EnemyMelee4.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged4[Random.Range(0, EnemyRanged4.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport4[Random.Range(0, EnemySupport4.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 34:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee4[Random.Range(0, EnemyMelee4.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged4[Random.Range(0, EnemyRanged4.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport4[Random.Range(0, EnemySupport4.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 35:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee4[Random.Range(0, EnemyMelee4.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged4[Random.Range(0, EnemyRanged4.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport4[Random.Range(0, EnemySupport4.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 36:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee4[Random.Range(0, EnemyMelee4.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged4[Random.Range(0, EnemyRanged4.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport4[Random.Range(0, EnemySupport4.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }
                break;
            case 37:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee4[Random.Range(0, EnemyMelee4.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged4[Random.Range(0, EnemyRanged4.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport4[Random.Range(0, EnemySupport4.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 38:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee4[Random.Range(0, EnemyMelee4.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged4[Random.Range(0, EnemyRanged4.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport4[Random.Range(0, EnemySupport4.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 39:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee4[Random.Range(0, EnemyMelee4.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged4[Random.Range(0, EnemyRanged4.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport4[Random.Range(0, EnemySupport4.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 40:
                BossOnScene = GameObject.FindGameObjectWithTag("Boss");

                switch (BossSelector)

                {
                    case 1:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject instance = Instantiate(BossPrefab4_1, BossOnScene.transform.position, BossOnScene.transform.rotation);
                        break;
                    case 2:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject instance2 = Instantiate(BossPrefab4_2, BossOnScene.transform.position, BossOnScene.transform.rotation);
                        break;
                    case 3:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject instance3 = Instantiate(BossPrefab4_3, BossOnScene.transform.position, BossOnScene.transform.rotation);
                        break;
                }

                break;
            case 41:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee5[Random.Range(0, EnemyMelee5.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged5[Random.Range(0, EnemyRanged5.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport5[Random.Range(0, EnemySupport5.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 42:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee5[Random.Range(0, EnemyMelee5.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged5[Random.Range(0, EnemyRanged5.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport5[Random.Range(0, EnemySupport5.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 43:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee5[Random.Range(0, EnemyMelee5.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged5[Random.Range(0, EnemyRanged5.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport5[Random.Range(0, EnemySupport5.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 44:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee5[Random.Range(0, EnemyMelee5.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged5[Random.Range(0, EnemyRanged5.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport5[Random.Range(0, EnemySupport5.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 45:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee5[Random.Range(0, EnemyMelee5.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged5[Random.Range(0, EnemyRanged5.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport5[Random.Range(0, EnemySupport5.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 46:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee5[Random.Range(0, EnemyMelee5.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged5[Random.Range(0, EnemyRanged5.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport5[Random.Range(0, EnemySupport5.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 47:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee5[Random.Range(0, EnemyMelee5.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged5[Random.Range(0, EnemyRanged5.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport5[Random.Range(0, EnemySupport5.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 48:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee5[Random.Range(0, EnemyMelee5.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged5[Random.Range(0, EnemyRanged5.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport5[Random.Range(0, EnemySupport5.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 49:
                EnemyMeleeOnScene = GameObject.FindGameObjectsWithTag("EnemyMelee");
                EnemyRangedOnScene = GameObject.FindGameObjectsWithTag("EnemyDist");
                EnemySupportOnScene = GameObject.FindGameObjectsWithTag("EnemySup");

                foreach (GameObject EnemyM in EnemyMeleeOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyMPrefab = EnemyMelee5[Random.Range(0, EnemyMelee5.Length)];
                    GameObject intance = Instantiate(EnemyMPrefab, EnemyM.transform.position, EnemyM.transform.rotation);
                }

                foreach (GameObject EnemyD in EnemyRangedOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemyDPrefab = EnemyRanged5[Random.Range(0, EnemyRanged5.Length)];
                    GameObject instance = Instantiate(EnemyDPrefab, EnemyD.transform.position, EnemyD.transform.rotation);
                }

                foreach (GameObject EnemyS in EnemySupportOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject EnemySPrefab = EnemySupport5[Random.Range(0, EnemySupport5.Length)];
                    GameObject instance = Instantiate(EnemySPrefab, EnemyS.transform.position, EnemyS.transform.rotation);
                }

                break;
            case 50:
                BossOnScene = GameObject.FindGameObjectWithTag("Boss");

                switch (BossSelector)

                {
                    case 1:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject instance = Instantiate(BossPrefab5_1, BossOnScene.transform.position, BossOnScene.transform.rotation);
                        break;
                    case 2:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject instance2 = Instantiate(BossPrefab5_2, BossOnScene.transform.position, BossOnScene.transform.rotation);
                        break;
                    case 3:
                        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                        GameObject instance3 = Instantiate(BossPrefab5_3, BossOnScene.transform.position, BossOnScene.transform.rotation);
                        break;
                }

                break;

        }



    }

    public void SetupScene(int Level)
    {
       
        BoardSetup();
        EnemySpawner();
        
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
