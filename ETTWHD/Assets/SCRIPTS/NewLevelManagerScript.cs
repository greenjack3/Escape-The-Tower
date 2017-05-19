using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;
using UnityEngine.UI;



public class NewLevelManagerScript : MonoBehaviour {

    // Tablice prefabów, Zrobić tablice dla etapów 6 i 7

    // Pokoje
    #region tablice pokoi 
    public GameObject[] CenterRoom;     // Tablica prefabów klatki schodowej dla poziomów 1-2
    public GameObject[] CenterRoom2;    // Tablica prefabów klatki schodowej dla poziomów 4-5
    public GameObject[] CenterRoom3;    // Tablica prefabów klatki schodowej dla poziomów 7-8
    public GameObject[] CenterRoom4;    // Tablica prefabów klatki schodowej dla poziomów 10-11
    public GameObject[] CenterRoom5;    // Tablica prefabów klatki schodowej dla poziomów 13-14
    public GameObject[] CenterRoom6;    // Tablica prefabów klatki schodowej dla poziomów 16-17
    public GameObject[] CenterRoom7;    // Tablica prefabów klatki schodowej dla poziomów 19-20
    public GameObject[] EdgeRoom;       // Tablica prefabów pokoi narożnych dla poziomów 1-2
    public GameObject[] EdgeRoom2;
    public GameObject[] EdgeRoom3;
    public GameObject[] EdgeRoom4;
    public GameObject[] EdgeRoom5;
    public GameObject[] InnerRoom;      // Tablica prefabów pokoi wewnętrznych dla poziomów 1-2
    public GameObject[] InnerRoom2;
    public GameObject[] InnerRoom3;
    public GameObject[] InnerRoom4;
    public GameObject[] InnerRoom5;
    public GameObject[] OuterRoom;      // Tablica prefabów pokoi zewnętrznych dla poziomów 1-2
    public GameObject[] OuterRoom2;
    public GameObject[] OuterRoom3;
    public GameObject[] OuterRoom4;
    public GameObject[] OuterRoom5;

    //Ściany
     
    public GameObject[] ExternalWall;   //Tablica prefabów zewnętrznych ścian z wyłączeniem ścian narożnych dla poziomów 1-2
    public GameObject[] ExternalWall2;
    public GameObject[] CornerWall;     //Tablica prefabów narożnych ścian dla poziomów 1-2
    public GameObject[] CornerWall2;
    public GameObject[] InnerWall;      // Tablica prefabów wewnętrznych ścian dla poziomów 1-2
    public GameObject[] InnerWall2;

    #endregion
    // Meble
    #region tablice mebli i obiektów na scenie 
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
    #endregion

    #region tablice przeciwników bez bossa
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
    #endregion
   
    #region tablice poziomów bossa 
    // Tablice poziomów Bossa
    public GameObject[] BoosLevel1_1; // Tablica poziomów dla 1 bossa na poziome 3
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
    #endregion

    #region spawnpointy
    //Tablice spawn pointów 
    public GameObject[] CenterRoomsOnScene; // Tablica spawn pointu klatki schodowej  
    public GameObject[] EdgeRoomsOnScene;   // Tablica spawn pointów pokoi narożnych 
    public GameObject[] InnerRoomsOnScene;  // Tablica spawn pointów pokoi wewnętrznych
    public GameObject[] OuterRoomsOnScene;  // Tablica spwan pointów pokoi zewnętrznych
    public GameObject[] ExternalWallsOnScene; // Tablica spawn pointów zewnętrznych ścian z wyłączeniem ścian narożnych
    public GameObject[] CornerWallsOnScene; // Tablica spawn pointów narożnych ścian
    public GameObject[] InnerWallsOnScene; // Tablica spawn pointów wewnętrznych ścian  
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
    #endregion
   
    #region tablica bossa
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
    #endregion
    
    #region gracz
    //Gracz
    public GameObject PlayerSpawner;
    public GameObject Hero;
    public GameObject HeroPrefab;
    public GameObject[] Body;
    public GameObject[] Head;
    public Material[] ClothMaterials;
    public Material[] SkinMaterials;
    public Material[] LeatherMaterials;
    public Material[] MetalMaterials;
    public Material[] HairMaterials;
    public Material[] NoseMaterials;
    public Material[] EyeMaterials;

    #region parametry
    //Zmienne i inne parametry
    // public Grid gridscript;
    public int RotationModifactor;
    public int BossSelector; // zmienna wybierająca bossa i jego level
    //public int pupy;
    //public Text PUPY;
  public int Level ;
    public LevelControler L;
    #endregion parametry
    //public GameObject SavedHero;
    #endregion gracz


    public void BoardSetup()
    {


        // if (CenterRooms == null)



    
      GameObject CenterPrefab ;
      GameObject instance ;

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

                foreach(GameObject Ściana in InnerWallsOnScene)
                {
                    GameObject InnerWallPrefab = InnerWall[Random.Range(0, InnerWall.Length)];
                    instance = Instantiate(InnerWallPrefab, Ściana.transform.position, Ściana.transform.rotation);
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

                LightSpotOnScene = GameObject.FindGameObjectsWithTag("LigthSpot");

                foreach (GameObject Światełko in LightSpotOnScene)
                {
                    GameObject.FindGameObjectWithTag("pointer").SetActive(false);
                    GameObject ŚwiatełkoPrefab = LightSpot2[Random.Range(0, LightSpot2.Length)];
                    instance = Instantiate(ŚwiatełkoPrefab, Światełko.transform.position, Światełko.transform.rotation);
                }
                break;
#endregion
            #region levle 10 
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
            #endregion
            #region do Poprawy
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

                #endregion




        }

        //  gridscript.GenerateGrid();

    }

   public void EnemySpawner()
    {
        EnemyMeleeOnScene = null;
        EnemyRangedOnScene = null;
        EnemySupportOnScene = null;
        switch (Level)
        {
            #region enemy level 1
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
#endregion
            #region enemy level 2
            case 2:
                EnemyMeleeOnScene = null;
                EnemyRangedOnScene = null;
                EnemySupportOnScene = null;
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
#endregion
            #region enemy level 3
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
#endregion
            #region enemy level 4
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
#endregion
            #region enemy level 5
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
#endregion
            #region enemy level 6
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
#endregion
            #region enemy level 7
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
#endregion
            #region enemy level 8
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
#endregion
            #region enemy level 9
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
#endregion
            #region do poprawki
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
            #region level 21
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
                #endregion

#endregion
        }



    }

    public void PlayerSpawn()
    {
        PlayerSpawner = null;
       

            GameObject.FindGameObjectWithTag("pointer").SetActive(false);
            PlayerSpawner = GameObject.FindGameObjectWithTag("PlayerSpawner");
        if (Level == 1)
        {

            GameObject hiro = Instantiate(Hero, PlayerSpawner.transform.position, PlayerSpawner.transform.rotation);
            GameObject body = Body[Random.Range(0, Body.Length)];
            GameObject b = Instantiate(body, hiro.transform.position, hiro.transform.rotation);
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            b.transform.parent = player.transform;
            GameObject HeadSpawner = GameObject.FindGameObjectWithTag("HeadSpawner");
            GameObject head = Head[Random.Range(0, Head.Length)];
            GameObject h = Instantiate(head, HeadSpawner.transform.position, HeadSpawner.transform.rotation);
            h.transform.parent = HeadSpawner.transform;
            // losowanie materiałów.

            GameObject HeroBody = GameObject.FindGameObjectWithTag("h");
            GameObject HeroHead = GameObject.FindGameObjectWithTag("HEAD");
            Material Skóra = SkinMaterials[Random.Range(0, SkinMaterials.Length)];
          Material[]bodyMats = HeroBody.GetComponent<Renderer>().materials;
            bodyMats[0] = Skóra;
            bodyMats[1] = ClothMaterials[Random.Range(0, ClothMaterials.Length)];
            bodyMats[2] = ClothMaterials[Random.Range(0, ClothMaterials.Length)];
            bodyMats[3] = LeatherMaterials[Random.Range(0, LeatherMaterials.Length)];
            bodyMats[4] = MetalMaterials[Random.Range(0, MetalMaterials.Length)];
            HeroBody.GetComponent<Renderer>().materials = bodyMats;

            Material[] headMats = HeroHead.GetComponent<Renderer>().materials;

            headMats[0] = Skóra;
            headMats[1] = HairMaterials[Random.Range(0, HairMaterials.Length)];
            headMats[2] = NoseMaterials[Random.Range(0, NoseMaterials.Length)];
            headMats[3] = EyeMaterials[Random.Range(0, EyeMaterials.Length)];

            HeroHead.GetComponent<Renderer>().materials = headMats;


        }
        GameObject hir = GameObject.FindGameObjectWithTag("Player");
        hir.transform.position = PlayerSpawner.transform.position;
        hir.transform.rotation = PlayerSpawner.transform.rotation;

    }

   
    

    public void SetupScene()
    {


         BoardSetup();
        LocalNavMeshBuilder.Instance.UpdateNavMesh();
        EnemySpawner();
        PlayerSpawn();
       
    }

    private void Awake()
    {
        
        L = GameObject.FindGameObjectWithTag("DM").GetComponent<LevelControler>();
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
        //        pupy = 0;
        GameObject hir = GameObject.FindGameObjectWithTag("Player");
        hir.transform.position = PlayerSpawner.transform.position;
        hir.transform.rotation = PlayerSpawner.transform.rotation;

    }

    //void Update()
    //{
    //    SetPupyText();
       
      
    //}
    //void SetPupyText()
    //{ 
    //    PUPY.text = "PUPy:" + pupy.ToString();
    //}

    //void AddPup(int PUPamount)
    //{
    //    pupy += PUPamount;
    //}
}
