using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NotebookButtonScript : MonoBehaviour {

   public void NotebookPage()
    {
        SceneManager.LoadScene("NotebookScene");
    }
}
