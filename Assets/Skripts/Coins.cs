using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Coins : MonoBehaviour
{
    public LootTipe lootTipe;
    public enum LootTipe {Coins, Food, Waser}
    public Data data;
    public Text coins;
    void Update()
    {
        if (lootTipe == LootTipe.Coins)
        {
            coins.text = "" + data.coins;
        }
        if (lootTipe == LootTipe.Food)
        {
            coins.text = "" + data.food;
        }
        if (lootTipe == LootTipe.Waser)
        {
            coins.text = "" + data.waser;
        }
    }
}
