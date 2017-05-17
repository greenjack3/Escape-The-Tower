using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTable : MonoBehaviour {
    public List<AudioClip> sounds = new List<AudioClip>();
    public List<AudioClip> sounds2 = new List<AudioClip>();
    public AudioSource audioSource;
    public int Level;
    public LevelControler L;
    // Use this for initialization
    private void Awake()
    {
        L = GameObject.FindGameObjectWithTag("DM").GetComponent<LevelControler>();
        Level = L.Level;
    }


    void Start () {

        SelectMusic();
        //audioSource.loop = false;
        //audioSource.clip = sounds[Random.Range(0, sounds.Count)];
        //audioSource.Play();
        

    }
	
	// Update is called once per frame
	void Update () {
        if (audioSource.time >= audioSource.clip.length)
        {
            ChangeMusic();
            Debug.Log("zmieniam");
        }
            
        //if (audioSource.time >= audioSource.clip.length)
        //{
        //    audioSource.clip = sounds[Random.Range(0, sounds.Count)];
        //    audioSource.Play();
        //}
    }


    public void SelectMusic()
    {
        switch (Level)
        {
            case 1:
                audioSource.loop = false;
                audioSource.clip = sounds[Random.Range(0, sounds.Count)];
                audioSource.Play();
                Debug.Log(audioSource.clip.length);

                break;
            case 2:
                audioSource.loop = false;
                audioSource.clip = sounds[Random.Range(0, sounds.Count)];
                audioSource.Play();

                break;
            case 3:
                audioSource.loop = false;
                audioSource.clip = sounds[Random.Range(0, sounds.Count)];
                audioSource.Play();

                break;
            case 4:
                audioSource.loop = false;
                audioSource.clip = sounds[Random.Range(0, sounds.Count)];
                audioSource.Play();

                break;
            case 5:
                audioSource.loop = false;
                audioSource.clip = sounds2[Random.Range(0, sounds2.Count)];
                audioSource.Play();

                break;
            case 6:
                audioSource.loop = false;
                audioSource.clip = sounds2[Random.Range(0, sounds2.Count)];
                audioSource.Play();

                break;
            case 7:
                audioSource.loop = false;
                audioSource.clip = sounds2[Random.Range(0, sounds2.Count)];
                audioSource.Play();

                break;
            case 8:
                audioSource.loop = false;
                audioSource.clip = sounds2[Random.Range(0, sounds2.Count)];
                audioSource.Play();

                break;
            case 9:
                audioSource.loop = false;
                audioSource.clip = sounds2[Random.Range(0, sounds2.Count)];
                audioSource.Play();

                break;
        }
    }

    public void ChangeMusic()
    {

        
            if( Level < 5)
            {
                //audioSource.loop = false;
                audioSource.clip = sounds[Random.Range(0, sounds.Count)];
                audioSource.Play();
            Debug.Log(audioSource.clip.length);

            }
            if ( Level >= 5)
            {
                audioSource.loop = false;
                audioSource.clip = sounds2[Random.Range(0, sounds2.Count)];
                audioSource.Play();
            }




            #region switch
            //switch (Level)
            //{
            //    case 1:
            //        audioSource.loop = false;
            //        audioSource.clip = sounds[Random.Range(0, sounds.Count)];
            //            audioSource.Play();

            //        break;
            //    case 2:
            //        audioSource.clip = sounds[Random.Range(0, sounds.Count)];
            //        audioSource.Play();
            //        break;
            //    case 3:
            //        audioSource.clip = sounds[Random.Range(0, sounds.Count)];
            //        audioSource.Play();
            //        break;
            //    case 4:
            //        audioSource.clip = sounds[Random.Range(0, sounds.Count)];
            //        audioSource.Play();
            //        break;
            //    case 5:
            //        audioSource.clip = sounds[Random.Range(0, sounds.Count)];
            //        audioSource.Play();
            //        break;
            //    case 6:
            //        audioSource.clip = sounds[Random.Range(0, sounds.Count)];
            //        audioSource.Play();
            //        break;
            //    case 7:
            //        audioSource.clip = sounds[Random.Range(0, sounds.Count)];
            //        audioSource.Play();
            //        break;
            //    case 8:
            //        audioSource.clip = sounds[Random.Range(0, sounds.Count)];
            //        audioSource.Play();
            //        break;
            //    case 9:
            //        audioSource.clip = sounds[Random.Range(0, sounds.Count)];
            //        audioSource.Play();
            //        break;
            //}
            #endregion
        
    }
}
