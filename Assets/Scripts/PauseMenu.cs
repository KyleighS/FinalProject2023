using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject cursor;
    public AudioSource audio;
    private float defaultPitch;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        audio.pitch = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            PauseGame();
            Cursor.visible = !cursor.activeSelf;
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
        cursor.SetActive(!cursor.activeSelf);

        if (pauseMenu.activeSelf)
        {
            audio.pitch = 0;
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        {
            audio.pitch = 1;
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void Restart(string sceneName)
    {
        //PauseGame();
        SceneManager.LoadScene(sceneName);
    }

    public void Quit()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void NextLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}

