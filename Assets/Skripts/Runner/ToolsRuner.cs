using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsRuner : MonoBehaviour
{
    public float speed = 30;
    void Start()
    {
        
    }
    void Update()
    {
        if (transform.position.z > -20)
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        else {
            Destroy(gameObject);
        }
    }
}
