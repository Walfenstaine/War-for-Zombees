using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pogoda : MonoBehaviour
{
    public Color deyColor;
    public Color nightColor;
    public Temme tim;
    public enum Temme {Day, Night}
    public Light lit;
    void Start()
    {
        if (tim == Temme.Day)
        {
            lit.color = deyColor;
            lit.intensity = 1;
        }
        else
        {
            lit.color = nightColor;
            lit.intensity = 0.4f;
        }
    }

}
