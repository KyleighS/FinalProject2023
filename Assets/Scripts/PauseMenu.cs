using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject cursor;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
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
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        {
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

