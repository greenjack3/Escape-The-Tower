using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NewGameButtonScript : MonoBehaviour {

	public void STARTGAME()
    {
        SceneManager.LoadScene("test");

    }
}
