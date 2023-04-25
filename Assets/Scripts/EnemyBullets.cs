using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullets : MonoBehaviour
{
    private GameObject player;
    private Rigidbody rb;
    public float force;
    private float life;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("Player");

        Vector3 dirc = player.transform.position - transform.position;
        rb.velocity = new Vector3(dirc.x, dirc.y, dirc.z) * force;

        float rotate = Mathf.Atan2(-dirc.x, -dirc.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotate);
    }

    // Update is called once per frame
    void Update()
    {
        life += Time.deltaTime;

        if(life > 5)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHealth>().health -= 1;
            Destroy(gameObject);
        }
    }
}
