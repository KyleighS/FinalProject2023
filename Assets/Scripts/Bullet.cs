using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3f;
    public int dmg = 1;
    public int targetNum = 3;

    void Awake()
    {
        Destroy(gameObject, life);
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
            TargetDown(targetNum, collision.transform);
        }
    }

    void Damage(Transform enemy)
    {
        EnemyHealth e = enemy.GetComponent<EnemyHealth>();
        if(e != null)
        {
            e.TakeDamage(dmg);
        }
    }
    
    void TargetDown(int numLeft, Transform target)
    {
        numLeft--;
        Door doors = door.GetComponent<Door>();
    }
}
