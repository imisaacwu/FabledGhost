using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public const int SCENE_MENU = 0;
    public const int SCENE_HOTEL = 1;

    public void play()
    {
        SceneManager.LoadScene(SCENE_HOTEL);
    }

    public void quit()
    {
        Application.Quit();
        Debug.Log("Application Quit");
    }
}