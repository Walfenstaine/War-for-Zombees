using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootElement : MonoBehaviour
{
    public AudioClip fude, vas;
    public Data data;
    public int index;
    public SpriteRenderer render;
    public Sprite fud, vaser;
    public LootTipe loot;
    public enum LootTipe {Food, Waser}
    void Start()
    {
        if (loot == LootTipe.Food)
        {
            render.sprite = fud;
        }
        else {
            render.sprite = vaser;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (loot == LootTipe.Food)
            {
                data.food += index;
                SoundPlayer.regit.sorse.PlayOneShot(fude);
            }
            else
            {
                SoundPlayer.regit.sorse.PlayOneShot(vas);
                data.waser += index;
            }
            Destroy(gameObject);
        }
    }
}
