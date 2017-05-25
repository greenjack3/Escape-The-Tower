using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DwarfSetter : MonoBehaviour {
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

    public Text strVal;
    public Text agiVal;
    public Text endVal;
    public Text intVal;

    public int STR;
    public int AGI;
    public int END;
    public int INT;

    public void Awake()
    {
        PlayerSpawn();
    }


    // Use this for initialization
    void Start()
    {

    }
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            ReloadLevel();
        }

    STR = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<DwarfSetterStats>().STR;
    AGI = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<DwarfSetterStats>().AGI;
    END = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<DwarfSetterStats>().END;
    INT = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<DwarfSetterStats>().INT;


        strVal.text = STR.ToString();
        agiVal.text = AGI.ToString();
        endVal.text = END.ToString();
        intVal.text = INT.ToString();

    }

    public void PlayerSpawn()
    {
        PlayerSpawner = null;


        GameObject.FindGameObjectWithTag("pointer").SetActive(false);
        PlayerSpawner = GameObject.FindGameObjectWithTag("PlayerSpawner");

        

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
            Material[] bodyMats = HeroBody.GetComponent<Renderer>().materials;
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


        
        GameObject hir = GameObject.FindGameObjectWithTag("Player");
        hir.transform.position = PlayerSpawner.transform.position;
        hir.transform.rotation = PlayerSpawner.transform.rotation;

    }


    public void ReloadLevel()
    {
        SceneManager.LoadScene("DD Dwarf creation");
    }
}
