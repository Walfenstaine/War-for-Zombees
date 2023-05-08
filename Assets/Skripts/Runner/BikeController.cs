using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeController : MonoBehaviour
{
    public Transform[] poses;
    public Animator anim;
    public int numPosa;
    void Update()
    {
        if (Vector3.Distance(transform.position, poses[numPosa].position) <= 0.5f)
        {
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, poses[numPosa].position, 3.5f * Time.deltaTime);
        }
    }
    public void MuweLeft()
    {
        if (numPosa == Mathf.Clamp(numPosa, 1, 2))
        {
            numPosa -= 1;
            anim.SetBool("Left", true);
        }
        
        anim.SetBool("Right", false);
    }
    public void MuweRight()
    {
        if (numPosa == Mathf.Clamp(numPosa, 0, 1))
        {
            numPosa += 1;
            anim.SetBool("Right", true);
        }
        
        anim.SetBool("Left", false);
    }
}
