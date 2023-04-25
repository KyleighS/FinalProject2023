using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3f;
    public int dmg = 1;
    public int targetNum = 1;
    public int enemyHealth = 5;

    public GameObject doorClosed;
    public GameObject doorOpen;

    void Awake()
    {
        Destroy(gameObject, life);
        //doorClosed.SetActive(true);
        //doorOpen.SetActive(false);
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        /*if(collision.gameObject.tag == "Emeny")
        {
            Damage(dmg);
            Destroy(gameObject);
        }*/

        if(collision.gameObject.tag == "Target")
        {
            targetNum--;

            if (targetNum <= 0)
            {
                Debug.Log("Victory");
                OpenDoor();
            }

            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            enemyHealth -= dmg;

            if (enemyHealth <= 0)
            {
                Destroy(gameObject);
            }

            Destroy(gameObject);
        }

    }
    /*void Damage(int dmg)
    {
        enemyHealth -= dmg;

        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }*/

    void OpenDoor()
    {
        doorClosed.SetActive(!doorClosed.activeSelf);
        doorOpen.SetActive(!doorOpen.activeSelf);
    }
}
