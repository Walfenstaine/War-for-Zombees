using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMob : MonoBehaviour {
    public Transform player;
    public NavMeshAgent agent;
	//public AudioClip clip;
	public Animator anim;
	void Start () {
        player = HelsController.rid.posa;
	}

	void Update () {
        if (player != null)
        {
            agent.destination = player.position;
        }
        
        anim.SetFloat("Speed", agent.velocity.magnitude/agent.speed);
        if (agent.velocity.magnitude > 0)
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }
	}
}
