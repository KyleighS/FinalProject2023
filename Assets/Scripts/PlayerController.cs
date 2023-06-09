using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //CharacterController handels the collisions and movement
    public CharacterController controller;
    public float speed = 1f;
    public GameObject victory;
    public GameObject cursor;

    void Start()
    {
        Time.timeScale = 1f;
        victory.SetActive(false);
        cursor.SetActive(true);
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Setp 1 get current position
        Vector3 currentPos = transform.position;
        Vector3 motion = Vector3.zero;

        //Setp 2 get player position
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        //Step 3 set new position based on input and speed
        currentPos.x = currentPos.x + speed * inputX * Time.deltaTime;

        //Step 4 repeat for Z
        currentPos.z = currentPos.z + speed * inputY * Time.deltaTime;

        //this will get us the vector of our movement, instead of new position
        motion = (transform.forward * speed * inputY * Time.deltaTime) +
            (transform.right * speed * inputX * Time.deltaTime);

        //instead of moving it normally, we can use the Character controller for motion
        controller.Move(motion);

    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "NextLevel")
        {
            SceneManager.LoadScene("Level_2");
        }
        if (collision.gameObject.tag == "Completed")
        {
            VictoryScreen();
        }
    }

    public void VictoryScreen()
    {
        victory.SetActive(true);
        cursor.SetActive(false);
        Cursor.visible = true;

        if (victory.activeSelf)
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
