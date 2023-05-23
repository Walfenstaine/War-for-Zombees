using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseMaster : MonoBehaviour
{
    public GameObject up;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            up.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            up.SetActive(true);
        }
    }
}
