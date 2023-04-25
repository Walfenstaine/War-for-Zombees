using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobLooter : MonoBehaviour
{
    public AudioClip hey;
    public GameObject prefab;
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SoundPlayer.regit.sorse.PlayOneShot(hey);
            anim.SetFloat("Speed", 1.0f);
        }
    }
    public void VeekUp()
    {
        Instantiate(prefab, transform.position, transform.rotation);
        Destroy(transform.parent.gameObject);
    }
}
