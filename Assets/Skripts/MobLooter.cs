using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InstantGamesBridge;
public class MobLooter : MonoBehaviour
{
    [SerializeField] private Language language;
    public AudioClip hey;
    public GameObject prefab;
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Subtitres.regit.timer = 0;
            if (Bridge.platform.language == "ru")
            {
                Subtitres.regit.subtitres = language.ru;
            }
            else
            {
                Subtitres.regit.subtitres = language.en;
            }
            
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
