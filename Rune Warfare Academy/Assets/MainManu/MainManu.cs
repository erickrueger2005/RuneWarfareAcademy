using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Map");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
