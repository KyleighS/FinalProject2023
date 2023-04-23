using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject doorClosed;
    public GameObject doorOpen;

    public void DoorSwap(int targetnum)
    {
        if(targetnum == 0)
        {
            doorClosed.SetActive(false);
            doorOpen.SetActive(true);
        }
    }
    
}
