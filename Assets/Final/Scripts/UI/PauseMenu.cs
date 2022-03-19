using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool IsGamePaused = false, soundSettings = true;
    public GameObject pauseMenuPanel, HUDPanel;
    public GameObject pauseFirstButton;
    public AudioListener audioListener;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseMenu.IsGamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuPanel.SetActive(false);
        HUDPanel.SetActive(true);
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        IsGamePaused = false;
    }
    public void restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level1");
    }
    public void onExitButtonClick()
    {
        Time.timeScale = 1f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("StartMenu");
    }
    public void Pause()
    {
        pauseMenuPanel.SetActive(true);
        HUDPanel.SetActive(false);
        Time.timeScale = 0f;
        IsGamePaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(pauseFirstButton);
    }
    
    public void onToggleSoundButtonClick()
    {
        if(soundSettings)
        {
            audioListener.enabled = false;
            soundSettings = false;
        }else
        {
            audioListener.enabled = true;
            soundSettings = true;
        }
    }
}