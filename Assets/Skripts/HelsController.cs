using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelsController : MonoBehaviour {
    public Transform posa { get; set; }
    public static HelsController rid { get; set; }

    void Awake()
    {
        posa = transform.parent;
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
    public void Normalised()
    {

    }
}
