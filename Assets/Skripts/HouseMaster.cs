using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseMaster : MonoBehaviour
{
    public GameObject up;
    private void OnTriggerEnter(Collider other)
    {
        up.SetActive(false);
    }
    private void OnTriggerExit(Collider other)
    {
        up.SetActive(true);
    }
}
