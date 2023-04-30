using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brusher : MonoBehaviour
{
    public Interface iF;
    public Text brush;
    public Data brusher;
    void Update()
    {
        if (brusher.record <= 0)
        {
            iF.Andlevel();
        }
        brush.text = "" + brusher.record;
    }
}
