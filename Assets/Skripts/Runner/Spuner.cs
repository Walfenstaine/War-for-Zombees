using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spuner : MonoBehaviour
{
    public GameObject[] spuns;
    public float spector = 15;
    public float interval;
    private float min;
    private float max;
    private float timer;
    private void Start()
    {
        min = transform.localPosition.x - spector;
        max = transform.localPosition.x + spector;
    }
    void Update()
    {
        if (timer < interval)
        {
            timer += Time.deltaTime;
        }
        else {
            float pX = Random.Range(min, max);
            Vector3 pos = new Vector3(pX, transform.position.y, transform.position.z);
            int num = Random.Range(0, spuns.Length);
            Instantiate(spuns[num], pos, Quaternion.identity);
            timer = 0;
        }
    }
}
