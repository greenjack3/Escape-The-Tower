using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDLevelCreation : MonoBehaviour
{

    public int Level;
    public LevelControler2 L;
    public int RotationModifactor;

    public GameObject[] CenterRoomsOnScene; // Tablica spawn pointu klatki schodowej  
    public GameObject[] EdgeRoomsOnScene;   // Tablica spawn pointów pokoi narożnych 
    public GameObject[] InnerRoomsOnScene;  // Tablica spawn pointów pokoi wewnętrznych
    public GameObject[] OuterRoomsOnScene;  // Tablica spwan pointów pokoi zewnętrznych
    public GameObject[] ExternalWallsOnScene; // Tablica spawn pointów zewnętrznych ścian z wyłączeniem ścian narożnych
    public GameObject[] CornerWallsOnScene; // Tablica spawn pointów narożnych ścian
    public GameObject[] InnerWallsOnScene; // Tablica spawn pointów wewnętrznych ścian  
    public GameObject[] ExternalCentralWallsOnScene;
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


    public GameObject[] CenterRoom;     // Tablica prefabów klatki schodowej dla poziomów 1-2
    public GameObject[] CenterRoom2;
    public GameObject[] EdgeRoom;       // Tablica prefabów pokoi narożnych dla poziomów 1-2
    public GameObject[] EdgeRoom2;
    public GameObject[] InnerRoom;      // Tablica prefabów pokoi wewnętrznych dla poziomów 1-2
    public GameObject[] InnerRoom2;
    public GameObject[] OuterRoom;      // Tablica prefabów pokoi zewnętrznych dla poziomów 1-2
    public GameObject[] OuterRoom2;

    public GameObject[] ExternalWall;   //Tablica prefabów zewnętrznych ścian z wyłączeniem ścian narożnych dla poziomów 1-2
    public GameObject[] ExternalWall2;
    public GameObject[] CornerWall;     //Tablica prefabów narożnych ścian dla poziomów 1-2
    public GameObject[] CornerWall2;
    public GameObject[] InnerWall;      // Tablica prefabów wewnętrznych ścian dla poziomów 1-2
    public GameObject[] InnerWall2;
    public GameObject[] ExternalCentralWall;
    public GameObject[] ExternalCentralWall2;

    public GameObject[] Mebelki_1x1;    // Tablica prefabów mebli 1x1 dla poziomów 1-9
    public GameObject[] Mebelki_1x1_2;
    public GameObject[] Mebelki_1x2;    // Tablica prefabów mebli 1x2 dla poziomów 1-9
    public GameObject[] Mebelki_1x2_2;
    public GameObject[] Mebelki_1x3;    // Tablica prefabów mebli 1x3 dla poziomów 1-9
    public GameObject[] Mebelki_1x3_2;
    public GameObject[] Mebelki_2x1;    // Tablica prefabów mebli 2x1 dla poziomów 1-9
    public GameObject[] Mebelki_2x1_2;
    public GameObject[] Mebelki_2x2;    // Tablica prefabów mebli 2x2 dla poziomów 1-9
    public GameObject[] Mebelki_2x2_2;
    public GameObject[] Mebelki_2x3;    // Tablica prefabów mebli 2x3 dla poziomów 1-9
    public GameObject[] Mebelki_2x3_2;
    public GameObject[] Mebelki_3x1;    // Tablica prefabów mebli 3x1 dla poziomów 1-9
    public GameObject[] Mebelki_3x1_2;
    public GameObject[] Mebelki_3x2;    // Tablica prefabów mebli 3x2 dla poziomów 1-9
    public GameObject[] Mebelki_3x2_2;
    public GameObject[] Mebelki_3x3;    // Tablica prefabów mebli 3x3 dla poziomów 1-9
    public GameObject[] Mebelki_3x3_2;

    // Kowadło
    public GameObject[] Kowadło;
    // Skrzynki
    public GameObject[] Skrzynia;
    public GameObject[] Skrzynia2;

    public GameObject[] Interactive;
    public GameObject[] Interactive2;

    public GameObject[] LightSpot;
    public GameObject[] LightSpot2;
    // Use this for initialization

    private void Awake()
    {

        L = GameObject.FindGameObjectWithTag("DM").GetComponent<LevelControler2>();
        Level = L.Level;
        GameObject[] PointersOnScene = GameObject.FindGameObjectsWithTag("pointer");
        foreach (GameObject pointer in PointersOnScene)
        {
            pointer.SetActive(false);
        }
        SetupScene();

    }

    void Start()
    {
        turnOffpointer();
    }

    // Update is called once per frame
    void Update()
    {


    }


    public void turnOffpointer()
    {
        GameObject[] pointers = GameObject.FindGameObjectsWithTag("pointer");
        if (pointers != null)
        {
            foreach (GameObject pointer in pointers)
            {
                pointer.SetActive(false);
            }
        }
    }

    public void SetupScene()
    {


        BoardSetup();

    }

    public void BoardSetup()
    {
        GameObject CenterPrefab;
        GameObject instance;

        switch (Level)
        {
            #region level 1 
            case 1:
                CenterRoomsOnScene = GameObject.FindGameObjectsWithTag("CR");

                EdgeRoomsOnScene = GameObject.FindGameObjectsWithTag("ER");

                InnerRoomsOnScene = GameObject.FindGameObjectsWithTag("IR");
                OuterRoomsOnScene = GameObject.FindGameObjectsWithTag("OR");


                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom[Random.Range(0, CenterRoom.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam i załadowałem level 1");

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



                ExternalWallsOnScene = GameObject.FindGameObjectsWithTag("ExternalWall");

                foreach (GameObject Ściana in ExternalWallsOnScene)
                {
                    GameObject ExternalWallPrefab = ExternalWall[Random.Range(0, ExternalWall.Length)];
                    instance = Instantiate(ExternalWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }

                CornerWallsOnScene = GameObject.FindGameObjectsWithTag("CornerWall");

                foreach (GameObject Ściana in CornerWallsOnScene)
                {
                    GameObject CornerWallPrefab = CornerWall[Random.Range(0, CornerWall.Length)];
                    instance = Instantiate(CornerWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }

                InnerWallsOnScene = GameObject.FindGameObjectsWithTag("InnerWall");

                foreach (GameObject Ściana in InnerWallsOnScene)
                {
                    GameObject InnerWallPrefab = InnerWall[Random.Range(0, InnerWall.Length)];
                    instance = Instantiate(InnerWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }
                ExternalCentralWallsOnScene = GameObject.FindGameObjectsWithTag("ExternalCentralWall");
                foreach (GameObject Ściana in ExternalCentralWallsOnScene)
                {
                    GameObject ExternalCentralWallPrefab = ExternalCentralWall[Random.Range(0, ExternalCentralWall.Length)];
                    instance = Instantiate(ExternalCentralWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot[Random.Range(0, LightSpot.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }
                break;
            #endregion
            #region level 2

            case 2:
                CenterRoomsOnScene = GameObject.FindGameObjectsWithTag("CR");

                EdgeRoomsOnScene = GameObject.FindGameObjectsWithTag("ER");

                InnerRoomsOnScene = GameObject.FindGameObjectsWithTag("IR");
                OuterRoomsOnScene = GameObject.FindGameObjectsWithTag("OR");



                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom[Random.Range(0, CenterRoom.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    print("działam i załadowałem level 2");

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


                ExternalWallsOnScene = GameObject.FindGameObjectsWithTag("ExternalWall");

                foreach (GameObject Ściana in ExternalWallsOnScene)
                {
                    GameObject ExternalWallPrefab = ExternalWall[Random.Range(0, ExternalWall.Length)];
                    instance = Instantiate(ExternalWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }

                CornerWallsOnScene = GameObject.FindGameObjectsWithTag("CornerWall");

                foreach (GameObject Ściana in CornerWallsOnScene)
                {
                    GameObject CornerWallPrefab = CornerWall[Random.Range(0, CornerWall.Length)];
                    instance = Instantiate(CornerWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }

                InnerWallsOnScene = GameObject.FindGameObjectsWithTag("InnerWall");

                foreach (GameObject Ściana in InnerWallsOnScene)
                {
                    GameObject InnerWallPrefab = InnerWall[Random.Range(0, InnerWall.Length)];
                    instance = Instantiate(InnerWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }
                ExternalCentralWallsOnScene = GameObject.FindGameObjectsWithTag("ExternalCentralWall");
                foreach (GameObject Ściana in ExternalCentralWallsOnScene)
                {
                    GameObject ExternalCentralWallPrefab = ExternalCentralWall[Random.Range(0, ExternalCentralWall.Length)];
                    instance = Instantiate(ExternalCentralWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }
                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot[Random.Range(0, LightSpot.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;
            #endregion
            #region level 3
            case 3:

                CenterRoomsOnScene = GameObject.FindGameObjectsWithTag("CR");

                EdgeRoomsOnScene = GameObject.FindGameObjectsWithTag("ER");

                InnerRoomsOnScene = GameObject.FindGameObjectsWithTag("IR");
                OuterRoomsOnScene = GameObject.FindGameObjectsWithTag("OR");


                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom[Random.Range(0, CenterRoom.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    Debug.Log("działam i załadowałem level 3");

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

                ExternalWallsOnScene = GameObject.FindGameObjectsWithTag("ExternalWall");

                foreach (GameObject Ściana in ExternalWallsOnScene)
                {
                    GameObject ExternalWallPrefab = ExternalWall[Random.Range(0, ExternalWall.Length)];
                    instance = Instantiate(ExternalWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }

                CornerWallsOnScene = GameObject.FindGameObjectsWithTag("CornerWall");

                foreach (GameObject Ściana in CornerWallsOnScene)
                {
                    GameObject CornerWallPrefab = CornerWall[Random.Range(0, CornerWall.Length)];
                    instance = Instantiate(CornerWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }

                InnerWallsOnScene = GameObject.FindGameObjectsWithTag("InnerWall");

                foreach (GameObject Ściana in InnerWallsOnScene)
                {
                    GameObject InnerWallPrefab = InnerWall[Random.Range(0, InnerWall.Length)];
                    instance = Instantiate(InnerWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }
                ExternalCentralWallsOnScene = GameObject.FindGameObjectsWithTag("ExternalCentralWall");
                foreach (GameObject Ściana in ExternalCentralWallsOnScene)
                {
                    GameObject ExternalCentralWallPrefab = ExternalCentralWall[Random.Range(0, ExternalCentralWall.Length)];
                    instance = Instantiate(ExternalCentralWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }
                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot[Random.Range(0, LightSpot.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }
                break;
            #endregion
            #region level 4
            case 4:
                CenterRoomsOnScene = GameObject.FindGameObjectsWithTag("CR");

                EdgeRoomsOnScene = GameObject.FindGameObjectsWithTag("ER");

                InnerRoomsOnScene = GameObject.FindGameObjectsWithTag("IR");
                OuterRoomsOnScene = GameObject.FindGameObjectsWithTag("OR");


                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom[Random.Range(0, CenterRoom.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    Debug.Log("działam i załadowałem level 4");

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



                ExternalWallsOnScene = GameObject.FindGameObjectsWithTag("ExternalWall");

                foreach (GameObject Ściana in ExternalWallsOnScene)
                {
                    GameObject ExternalWallPrefab = ExternalWall[Random.Range(0, ExternalWall.Length)];
                    instance = Instantiate(ExternalWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }

                CornerWallsOnScene = GameObject.FindGameObjectsWithTag("CornerWall");

                foreach (GameObject Ściana in CornerWallsOnScene)
                {
                    GameObject CornerWallPrefab = CornerWall[Random.Range(0, CornerWall.Length)];
                    instance = Instantiate(CornerWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }

                InnerWallsOnScene = GameObject.FindGameObjectsWithTag("InnerWall");

                foreach (GameObject Ściana in InnerWallsOnScene)
                {
                    GameObject InnerWallPrefab = InnerWall[Random.Range(0, InnerWall.Length)];
                    instance = Instantiate(InnerWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }
                ExternalCentralWallsOnScene = GameObject.FindGameObjectsWithTag("ExternalCentralWall");
                foreach (GameObject Ściana in ExternalCentralWallsOnScene)
                {
                    GameObject ExternalCentralWallPrefab = ExternalCentralWall[Random.Range(0, ExternalCentralWall.Length)];
                    instance = Instantiate(ExternalCentralWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }
                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot[Random.Range(0, LightSpot.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;
            #endregion
            #region level 5
            case 5:
                CenterRoomsOnScene = GameObject.FindGameObjectsWithTag("CR");

                EdgeRoomsOnScene = GameObject.FindGameObjectsWithTag("ER");

                InnerRoomsOnScene = GameObject.FindGameObjectsWithTag("IR");
                OuterRoomsOnScene = GameObject.FindGameObjectsWithTag("OR");


                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom2[Random.Range(0, CenterRoom2.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    Debug.Log("działam i załadowałem level 5");

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



                ExternalWallsOnScene = GameObject.FindGameObjectsWithTag("ExternalWall");

                foreach (GameObject Ściana in ExternalWallsOnScene)
                {
                    GameObject ExternalWallPrefab = ExternalWall2[Random.Range(0, ExternalWall2.Length)];
                    instance = Instantiate(ExternalWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }

                CornerWallsOnScene = GameObject.FindGameObjectsWithTag("CornerWall");

                foreach (GameObject Ściana in CornerWallsOnScene)
                {
                    GameObject CornerWallPrefab = CornerWall2[Random.Range(0, CornerWall2.Length)];
                    instance = Instantiate(CornerWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }

                InnerWallsOnScene = GameObject.FindGameObjectsWithTag("InnerWall");

                foreach (GameObject Ściana in InnerWallsOnScene)
                {
                    GameObject InnerWallPrefab = InnerWall2[Random.Range(0, InnerWall2.Length)];
                    instance = Instantiate(InnerWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }
                ExternalCentralWallsOnScene = GameObject.FindGameObjectsWithTag("ExternalCentralWall");
                foreach (GameObject Ściana in ExternalCentralWallsOnScene)
                {
                    GameObject ExternalCentralWallPrefab = ExternalCentralWall2[Random.Range(0, ExternalCentralWall2.Length)];
                    instance = Instantiate(ExternalCentralWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }
                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot2[Random.Range(0, LightSpot2.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }
                break;
            #endregion
            #region level 6
            case 6:
                CenterRoomsOnScene = GameObject.FindGameObjectsWithTag("CR");

                EdgeRoomsOnScene = GameObject.FindGameObjectsWithTag("ER");

                InnerRoomsOnScene = GameObject.FindGameObjectsWithTag("IR");
                OuterRoomsOnScene = GameObject.FindGameObjectsWithTag("OR");


                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom2[Random.Range(0, CenterRoom2.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    Debug.Log("działam i załadowałem level 6");

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



                ExternalWallsOnScene = GameObject.FindGameObjectsWithTag("ExternalWall");

                foreach (GameObject Ściana in ExternalWallsOnScene)
                {
                    GameObject ExternalWallPrefab = ExternalWall2[Random.Range(0, ExternalWall2.Length)];
                    instance = Instantiate(ExternalWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }

                CornerWallsOnScene = GameObject.FindGameObjectsWithTag("CornerWall");

                foreach (GameObject Ściana in CornerWallsOnScene)
                {
                    GameObject CornerWallPrefab = CornerWall2[Random.Range(0, CornerWall2.Length)];
                    instance = Instantiate(CornerWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }

                InnerWallsOnScene = GameObject.FindGameObjectsWithTag("InnerWall");

                foreach (GameObject Ściana in InnerWallsOnScene)
                {
                    GameObject InnerWallPrefab = InnerWall2[Random.Range(0, InnerWall2.Length)];
                    instance = Instantiate(InnerWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }
                ExternalCentralWallsOnScene = GameObject.FindGameObjectsWithTag("ExternalCentralWall");
                foreach (GameObject Ściana in ExternalCentralWallsOnScene)
                {
                    GameObject ExternalCentralWallPrefab = ExternalCentralWall2[Random.Range(0, ExternalCentralWall2.Length)];
                    instance = Instantiate(ExternalCentralWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }
                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot2[Random.Range(0, LightSpot2.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }
                break;
            #endregion
            #region levle 7
            case 7:
                CenterRoomsOnScene = GameObject.FindGameObjectsWithTag("CR");

                EdgeRoomsOnScene = GameObject.FindGameObjectsWithTag("ER");

                InnerRoomsOnScene = GameObject.FindGameObjectsWithTag("IR");
                OuterRoomsOnScene = GameObject.FindGameObjectsWithTag("OR");


                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom2[Random.Range(0, CenterRoom2.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    Debug.Log("działam i załadowałem level 7");

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


                ExternalWallsOnScene = GameObject.FindGameObjectsWithTag("ExternalWall");

                foreach (GameObject Ściana in ExternalWallsOnScene)
                {
                    GameObject ExternalWallPrefab = ExternalWall2[Random.Range(0, ExternalWall2.Length)];
                    instance = Instantiate(ExternalWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }

                CornerWallsOnScene = GameObject.FindGameObjectsWithTag("CornerWall");

                foreach (GameObject Ściana in CornerWallsOnScene)
                {
                    GameObject CornerWallPrefab = CornerWall2[Random.Range(0, CornerWall2.Length)];
                    instance = Instantiate(CornerWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }

                InnerWallsOnScene = GameObject.FindGameObjectsWithTag("InnerWall");

                foreach (GameObject Ściana in InnerWallsOnScene)
                {
                    GameObject InnerWallPrefab = InnerWall2[Random.Range(0, InnerWall2.Length)];
                    instance = Instantiate(InnerWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }
                ExternalCentralWallsOnScene = GameObject.FindGameObjectsWithTag("ExternalCentralWall");
                foreach (GameObject Ściana in ExternalCentralWallsOnScene)
                {
                    GameObject ExternalCentralWallPrefab = ExternalCentralWall2[Random.Range(0, ExternalCentralWall2.Length)];
                    instance = Instantiate(ExternalCentralWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }
                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot2[Random.Range(0, LightSpot2.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;
            #endregion
            #region level 8
            case 8:
                CenterRoomsOnScene = GameObject.FindGameObjectsWithTag("CR");

                EdgeRoomsOnScene = GameObject.FindGameObjectsWithTag("ER");

                InnerRoomsOnScene = GameObject.FindGameObjectsWithTag("IR");
                OuterRoomsOnScene = GameObject.FindGameObjectsWithTag("OR");


                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom2[Random.Range(0, CenterRoom2.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    Debug.Log("działam i załadowałem level 8");

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



                ExternalWallsOnScene = GameObject.FindGameObjectsWithTag("ExternalWall");

                foreach (GameObject Ściana in ExternalWallsOnScene)
                {
                    GameObject ExternalWallPrefab = ExternalWall2[Random.Range(0, ExternalWall2.Length)];
                    instance = Instantiate(ExternalWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }

                CornerWallsOnScene = GameObject.FindGameObjectsWithTag("CornerWall");

                foreach (GameObject Ściana in CornerWallsOnScene)
                {
                    GameObject CornerWallPrefab = CornerWall2[Random.Range(0, CornerWall2.Length)];
                    instance = Instantiate(CornerWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }

                InnerWallsOnScene = GameObject.FindGameObjectsWithTag("InnerWall");

                foreach (GameObject Ściana in InnerWallsOnScene)
                {
                    GameObject InnerWallPrefab = InnerWall2[Random.Range(0, InnerWall2.Length)];
                    instance = Instantiate(InnerWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }
                ExternalCentralWallsOnScene = GameObject.FindGameObjectsWithTag("ExternalCentralWall");
                foreach (GameObject Ściana in ExternalCentralWallsOnScene)
                {
                    GameObject ExternalCentralWallPrefab = ExternalCentralWall2[Random.Range(0, ExternalCentralWall2.Length)];
                    instance = Instantiate(ExternalCentralWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }
                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot2[Random.Range(0, LightSpot2.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }

                break;
            #endregion
            #region level 9
            case 9:
                CenterRoomsOnScene = GameObject.FindGameObjectsWithTag("CR");

                EdgeRoomsOnScene = GameObject.FindGameObjectsWithTag("ER");

                InnerRoomsOnScene = GameObject.FindGameObjectsWithTag("IR");
                OuterRoomsOnScene = GameObject.FindGameObjectsWithTag("OR");


                foreach (GameObject Room in CenterRoomsOnScene)
                {
                    CenterPrefab = CenterRoom2[Random.Range(0, CenterRoom2.Length)];
                    instance = (GameObject)Instantiate(CenterPrefab, Room.transform.position, Room.transform.rotation);
                    Debug.Log("działam i załadowałem level 9");

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



                ExternalWallsOnScene = GameObject.FindGameObjectsWithTag("ExternalWall");

                foreach (GameObject Ściana in ExternalWallsOnScene)
                {
                    GameObject ExternalWallPrefab = ExternalWall2[Random.Range(0, ExternalWall2.Length)];
                    instance = Instantiate(ExternalWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }

                CornerWallsOnScene = GameObject.FindGameObjectsWithTag("CornerWall");

                foreach (GameObject Ściana in CornerWallsOnScene)
                {
                    GameObject CornerWallPrefab = CornerWall2[Random.Range(0, CornerWall2.Length)];
                    instance = Instantiate(CornerWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }

                InnerWallsOnScene = GameObject.FindGameObjectsWithTag("InnerWall");

                foreach (GameObject Ściana in InnerWallsOnScene)
                {
                    GameObject InnerWallPrefab = InnerWall2[Random.Range(0, InnerWall2.Length)];
                    instance = Instantiate(InnerWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }
                ExternalCentralWallsOnScene = GameObject.FindGameObjectsWithTag("ExternalCentralWall");
                foreach (GameObject Ściana in ExternalCentralWallsOnScene)
                {
                    GameObject ExternalCentralWallPrefab = ExternalCentralWall2[Random.Range(0, ExternalCentralWall2.Length)];
                    instance = Instantiate(ExternalCentralWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
                }
                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot2[Random.Range(0, LightSpot2.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }
                break;
                #endregion

        }
    }
}