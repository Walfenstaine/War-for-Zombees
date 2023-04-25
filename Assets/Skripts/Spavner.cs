using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spavner : MonoBehaviour {
	public GameObject spavner;
	public float intensive;
	private float timer;

	void Update () {
		timer += Time.deltaTime;
		if (timer >= intensive) {
			Instantiate (spavner, transform.position, transform.rotation);
			timer = 0;
		}
	}
}
