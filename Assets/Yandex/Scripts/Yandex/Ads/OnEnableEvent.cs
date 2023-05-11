using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnEnableEvent : MonoBehaviour
{
    public UnityEvent OnEvent, OffEvent;

    public float deltaT = 0.8f;
    
    void OnEnable()
    {
        Invoke("Enable", deltaT); 
    }

    void Enable()
    {
        OnEvent.Invoke();
    }

    void OnDisable()
    {
        OffEvent.Invoke();
    }
}
