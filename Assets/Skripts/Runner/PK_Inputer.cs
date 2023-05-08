using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PK_Inputer : MonoBehaviour
{
    public BikeController bC;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            bC.MuweLeft();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            bC.MuweRight();
        }
    }
}
