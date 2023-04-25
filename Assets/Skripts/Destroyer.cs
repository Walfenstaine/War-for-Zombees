using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject loot;
    public PlayerHelse pHelse;
    public Equers equers;
    public enum Equers { Player, Mob }
    public Helse helse;
    public GameObject destroy;

    private void Start()
    {
        if (equers == Equers.Mob)
        {
            Interface.regit.brush += 1;
        }
            
    }
    public void Destroy()
    {
        if (equers == Equers.Mob)
        {
            Interface.regit.brush -= 1;
            Instantiate(loot, transform.position, Quaternion.identity);
        }
       
        Destroy(destroy);
    }
    public void Normalised()
    {
        if (equers == Equers.Player)
        {
            pHelse.Normalised();
        }
        else
        {
            helse.Normalised();
        }
    }
}
