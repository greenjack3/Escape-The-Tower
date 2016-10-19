using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SettingsButtonScript : MonoBehaviour {

   public void SettingsPage()
    {
        SceneManager.LoadScene("SettingsScene");
    }
}
