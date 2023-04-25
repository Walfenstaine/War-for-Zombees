using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFiter : MonoBehaviour
{
    public Data data;
    public NavMeshAgent agent;
    public Animator anim;
    public EnemiAI ai;
    public void Fite()
    {
        agent.isStopped= true;
        ai.enabled = false;
    }
    public void Kik()
    {
        if (ai.player != null)
        {
            if (Vector3.Distance(transform.position,ai.player.position) <= 4)
            {
                ai.player.GetComponent<PlayerHelse>().Damage();
                ai.player.GetComponent<PlayerHelse>().helse -= 10 + data.record;
            }
        }
    }
    public void Resed()
    {
        anim.SetBool("Kik", false);
        if (ai != null && agent != null)
        {
            agent.isStopped = false;
            ai.enabled = true;
        }
       
    }
}
