using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Interface iF = FindObjectOfType<Interface>() as Interface;
            iF.Ded();
        }
    }
}
