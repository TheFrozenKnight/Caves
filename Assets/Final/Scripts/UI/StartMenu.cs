using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void onPlayButtonClick()
    {
        SceneManager.LoadScene("Level1");
    }
    public void onCreditsButtonClick()
    {
        SceneManager.LoadScene("Credits");
    }
    public void onExitButtonClick()
    {
        Application.Quit();
    }
}
