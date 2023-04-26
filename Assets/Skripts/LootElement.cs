using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InstantGamesBridge;
public class LootElement : MonoBehaviour
{
    [SerializeField] private Language languageWaser;
    [SerializeField] private Language languageFood;
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
            Subtitres.regit.timer = 0;
            if (loot == LootTipe.Food)
            {
                if (Bridge.platform.language == "ru")
                {
                    Subtitres.regit.subtitres = languageFood.ru + " +" + index;
                }
                else
                {
                    Subtitres.regit.subtitres = languageFood.en + " +" + index;
                }
                data.food += index;
                SoundPlayer.regit.sorse.PlayOneShot(fude);
            }
            else
            {
                if (Bridge.platform.language == "ru")
                {
                    Subtitres.regit.subtitres = languageWaser.ru + " +" + index;
                }
                else
                {
                    Subtitres.regit.subtitres = languageWaser.en + " +" + index;
                }
                SoundPlayer.regit.sorse.PlayOneShot(vas);
                data.waser += index;
            }
            Destroy(gameObject);
        }
    }
}
