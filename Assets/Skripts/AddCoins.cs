using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddCoins : MonoBehaviour
{
    public Text text;
    public Data data;
    public AudioClip clip;

    public void Addcoins()
    {
        SoundPlayer.regit.sorse.PlayOneShot(clip);
        data.coins += data.record * 100;
        SaveAndLoad.Instance.Save();
    }
    private void Update()
    {
        text.text = "+" + data.record * 100;
    }
}
