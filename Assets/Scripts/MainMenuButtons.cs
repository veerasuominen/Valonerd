using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadEmojiScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadAbilityScene()
    {
        SceneManager.LoadScene(2);
    }

    public void CloseApplication()
    {
        Application.Quit();
    }
}