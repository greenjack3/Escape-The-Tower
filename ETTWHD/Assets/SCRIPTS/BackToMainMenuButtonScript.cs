using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackToMainMenuButtonScript : MonoBehaviour
{

	public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
