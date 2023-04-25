using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 10;
    public GameObject gameOver;
    public GameObject cursor;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        gameOver.SetActive(false);
        cursor.SetActive(true);
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            GameOver();
            Cursor.visible = true;
        }
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        cursor.SetActive(false);

        if (gameOver.activeSelf)
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
}
