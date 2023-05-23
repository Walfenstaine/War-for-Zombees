using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public float intensive = 2.0f;
    public Interface iF;
    public CharacterController player;

    void Update()
    {
        if (player != null)
        {
            Vector3 pos = player.transform.position + player.velocity;
            transform.position = Vector3.Lerp(transform.position, pos, intensive * Time.deltaTime);
        }
        else {
            iF.Ded();
        }
    }
}
