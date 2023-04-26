using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    public GameObject closedDoor;
    public GameObject openDoor;
    [SerializeField] float targets, maxTargets;

    private void Start()
    {
        targets = maxTargets;
        closedDoor.SetActive(true);
        openDoor.SetActive(false);
    }
    public void TargetDown(float num)
    {
        Destroy(gameObject);
        targets -= num;

        if (targets <= 0)
        {
            closedDoor.SetActive(false);
            openDoor.SetActive(true);
        }
    }
}
