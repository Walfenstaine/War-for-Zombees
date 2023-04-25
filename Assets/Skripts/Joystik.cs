using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystik : MonoBehaviour
{
    public Muwer muwer;
    private void Start()
    {
        muwer = Muwer.regit;
    }
    public void PointStop()
    {
        muwer.muve.z = 0;
        muwer.muve.x = 0;
    }
    public void PointUp()
    {
        muwer.muve.z = 1;
    }
    public void PointDown()
    {
        muwer.muve.z = -1;
    }
    public void PointRight()
    {
        muwer.muve.x = 1;
    }
    public void PointLeft()
    {
        muwer.muve.x = -1;
    }
}
