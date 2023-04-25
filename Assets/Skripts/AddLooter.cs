using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLooter : MonoBehaviour
{
    public AudioClip clip, nou;
    public Data data;
    public Loot looter;
    public enum Loot {Food, Waser}
    public void OnCoin()
    {
        if (looter == Loot.Food)
        {
            if (data.coins > 100)
            {
                SoundPlayer.regit.sorse.PlayOneShot(clip);
                data.food += 5;
                data.coins -= 100;
            }
            else {
                SoundPlayer.regit.sorse.PlayOneShot(nou);
            }
           
        }
        else
        {
            if (data.coins > 100)
            {
                SoundPlayer.regit.sorse.PlayOneShot(clip);
                data.waser += 5;
                data.coins -= 100;
            }
            else {
                SoundPlayer.regit.sorse.PlayOneShot(nou);
            }
        }
    }
    public void OnReclame()
    {
        if (looter == Loot.Food)
        {
            data.food += 5;
        }
        else
        {
            data.waser += 5;
        }
    }
}
