using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    public AudioClip clip;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Interface iF = FindObjectOfType<Interface>() as Interface;
            SoundPlayer.regit.sorse.Stop();
            SoundPlayer.regit.sorse.PlayOneShot(clip);
            iF.Ded();
        }
    }
}
