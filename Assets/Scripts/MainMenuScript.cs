using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
   public void PlayGame(int NumberOfScene)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + NumberOfScene);
    }

    public void ExitGame()
    {
        Debug.Log("Exit Work");
        Application.Quit();
    }
}
