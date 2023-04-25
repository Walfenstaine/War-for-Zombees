using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
public class Helse : MonoBehaviour
{
    public AudioClip clip;
    public Data data;
    public ParticleSystem ps;
    public BoxCollider box;
    public NavMeshAgent agent;
    public EnemiAI ai;
    public Animator anim;
    public float helse;
    public Image hpBar;
    private float timer;

    private void Start()
    {
        helse = 100 + data.record;
        hpBar.enabled = false;
        timer = 0;
    }
    public void Damage()
    {
        ps.Play();
        timer = 1.1f;
        hpBar.enabled = true;
        agent.isStopped = true;
        if (ai != null)
        {
            ai.enabled = false;
        }
        
        if (helse <= 0)
        {
            agent.isStopped = true;
            Destroy(ai);
            anim.SetBool("Ded", true);
            if (box.enabled)
            {
                SoundPlayer.regit.sorse.PlayOneShot(clip);
                box.enabled = false;
            }
           
        }
        else
        {
            anim.SetBool("Damage", true);
        }
    }
    public void Normalised()
    {
        if (helse > 0)
        {
            agent.isStopped = false;
            ai.enabled = true;
        }
        anim.SetBool("Damage", false);
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
        hpBar.fillAmount = helse / (100+data.record);
    }
}
