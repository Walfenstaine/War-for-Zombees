using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lootcoins : MonoBehaviour
{
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
            SoundPlayer.regit.sorse.PlayOneShot(coin);
            Destroy(gameObject);
            data.coins += inndex;
        }
    }
}
