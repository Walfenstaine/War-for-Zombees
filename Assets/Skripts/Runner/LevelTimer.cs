using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelTimer : MonoBehaviour
{
    public Interface iF;
    public Scrollbar bar;
    public float andTime;
    private float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < andTime)
        {
            timer += Time.deltaTime;
        }
        else {
            iF.Andlevel();
        }
        bar.value = timer / andTime;
    }
}
