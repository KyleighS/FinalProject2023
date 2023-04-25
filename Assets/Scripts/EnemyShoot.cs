using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;

    private float timer;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        //Debug.Log(distance);
        if(distance <= 3)
        {
            timer += Time.deltaTime;

            if (timer > 5)
            {
                timer = 0;
                Shoot();
            }
        }
    }

    void Shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}
    /*public Transform target;
    public float range = 4;

    public string playerTag = "Player";

    public float fireRate = 1f;
    private float fireCountdown = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void UpdateTarget()
    {
        GameObject[] player = GameObject.FindGameObjectsWithTag(playerTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearplayer = null;
        foreach(GameObject p in player)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, p.transform.position);
            if(distanceToPlayer < shortestDistance)
            {
                shortestDistance = distanceToPlayer;
                nearplayer = p;
            }
        }
        if(nearplayer != null && shortestDistance <= range)
        {
            target = nearplayer.transform;
        }
        else
        {
            target = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            return;
        }

        if(fireCountdown <= 0)
        {
            Shoot();
            fireCountdown = 1f/fireRate;
        }

        fireCountdown -= Time.deltaTime;
    }

    void Shoot()
    {
        Debug.Log("SHOOT!");
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }*/
