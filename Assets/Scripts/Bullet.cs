using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3f;
    public int dmg = 1;
    public int targetNum;

    public GameObject doorClosed;
    public GameObject doorOpen;

    void Awake()
    {
        Destroy(gameObject, life);
        doorClosed.SetActive(true);
        doorOpen.SetActive(false);
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Emeny")
        {
            Damage(collision.transform);
        }

        if(collision.gameObject.tag == "Target")
        {
            Destroy(gameObject);

            //targetNum--;

            /*if (targetNum <= 0)
            {
                doorClosed.SetActive(!doorClosed.activeSelf);
                doorOpen.SetActive(!doorOpen.activeSelf);
            }*/
        }
    }

    void Damage(Transform enemy)
    {
        EnemyHealth e = enemy.GetComponent<EnemyHealth>();
        e.TakeDamage(dmg);
    }
    
}
