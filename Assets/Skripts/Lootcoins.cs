using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InstantGamesBridge;
public class Lootcoins : MonoBehaviour
{
    [SerializeField] private Language language;
    public AudioClip coin;
    public Data data;
    private int inndex;
    void Start()
    {
        inndex = Random.Range((data.record*5), (data.record * 5)+5);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Subtitres.regit.timer = 0;
            if (Bridge.platform.language == "ru")
            {
                Subtitres.regit.subtitres = language.ru + " +" + inndex;
            }
            else
            {
                Subtitres.regit.subtitres = language.en + " +" + inndex;
            }
            SoundPlayer.regit.sorse.PlayOneShot(coin);
            Destroy(gameObject);
            data.coins += inndex;
        }
    }
}
