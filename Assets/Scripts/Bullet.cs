using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3f;
    void Awake()
    {
        Destroy(gameObject, life);
        Time.timeScale = 1f;
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<EnemyHealth>(out EnemyHealth enemyHealth))
        {
            enemyHealth.TakeDamage(1);
        }

        if (other.gameObject.TryGetComponent<Targets>(out Targets targets))
        {
            targets.TargetDown(1);
        }
    }


}
