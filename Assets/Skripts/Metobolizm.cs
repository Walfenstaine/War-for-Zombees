using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metobolizm : MonoBehaviour
{
    public AudioClip yet, doNt;
    public Data data;
    public PlayerHelse helse;
    public int fudConfirm = 1;
    public int waserConfirm = 1;
    public float eetInterval = 30.0f;
    private float timer;
    private Interface iF;

    private void Start()
    {
        iF = GameObject.FindGameObjectWithTag("Interface").GetComponent<Interface>();
    }
    void Update()
    {
        if (timer <= eetInterval)
        {
            timer += Time.deltaTime;
        }
        else {
            timer = 0;
            if (data.food > 0)
            {
                SoundPlayer.regit.sorse.PlayOneShot(yet);
                data.food -= fudConfirm;
            }
            else
            {
                SoundPlayer.regit.sorse.PlayOneShot(doNt);
                iF.Golod();
                helse.Damage();
                helse.helse -= 50;
            }
            if (data.waser > 0)
            {
                data.waser -= waserConfirm;
            }
            else {
                iF.Golod();
                helse.Damage();
                helse.helse -= 50;
            }
            
        }
    }
}
