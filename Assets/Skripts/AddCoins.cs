using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCoins : MonoBehaviour
{
    public Data data;
    public AudioClip clip;

    public void Addcoins()
    {
        SoundPlayer.regit.sorse.PlayOneShot(clip);
        data.coins += 100;
        SaveAndLoad.Instance.Save();
    }
}
