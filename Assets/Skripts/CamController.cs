using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public Interface iF;
    public CharacterController player;
    void Update()
    {
        if (player != null)
        {
            transform.position = Vector3.Lerp(transform.position, player.transform.position+player.velocity, 3.5f * Time.deltaTime);
        }
        else {
            iF.Ded();
        }
    }
}
