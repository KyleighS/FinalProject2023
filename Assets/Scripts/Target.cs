using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 5f;

    public void TakeDmg(float amount)
    {
        health -= amount;
    }
}
