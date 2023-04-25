using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
public class PlayerHelse : MonoBehaviour
{
    public AudioClip auch, dead;
    public Data data;
    public PlayerMob mob;
    public Muwer muwer;
    public Equers equers;
    public enum Equers { Player, Mob }
    public NavMeshAgent agent;
    public ParticleSystem ps;
    public float helse;
    public Animator anim;
    public Image hpBar;
    private float timer;

    private void Start()
    {
        if (equers == Equers.Player)
        {
            helse = data.playerHelse;
        }
        else
        {
            helse = data.mobHelse;
        }
    }
    public void Damage()
    {
        ps.Play();
        timer = 1.1f;
        hpBar.enabled = true;
        if (equers == Equers.Player)
        {
            muwer.enabled = false;
        }
        else
        {
            agent.enabled = false;
            mob.enabled = false;
        }
        
        if (helse <= 0)
        {
            SoundPlayer.regit.sorse.PlayOneShot(dead);
            anim.SetBool("Ded", true);
        }
        else
        {
            SoundPlayer.regit.sorse.PlayOneShot(auch);
            anim.SetBool("Damage", true);
        }
    }
    public void Normalised()
    {
        anim.SetBool("Damage", false);
        if (equers == Equers.Player)
        {
            muwer.enabled = true;
        }
        else
        {
            agent.enabled = true;
            mob.enabled = true;
        }

    }
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            hpBar.enabled = false;
            timer = 0;
        }

        if (equers == Equers.Player)
        {
            hpBar.fillAmount = helse / data.playerHelse;
        }
        else
        {
            hpBar.fillAmount = helse / data.mobHelse;
        } 
    }
}
