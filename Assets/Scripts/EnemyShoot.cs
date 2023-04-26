using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    public int force = 5;

    private float timer;
    private GameObject player;

    Animator animator;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        bullet.GetComponent<Rigidbody>().velocity = bulletPos.forward * force;
        //Debug.Log(distance);


        if (distance <= 3)
        {
            timer += Time.deltaTime;
            animator.SetBool("Stopped", true);

            if (timer > 3)
            {
                timer = 0;
                Shoot();
            }
        }

        if(distance > 3)
        {
            animator.SetBool("Stopped", false);
        }
    }

    void Shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}
    
