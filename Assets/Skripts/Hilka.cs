using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hilka : MonoBehaviour {
	public string masage;
	public AudioClip clip;
	public int hels;
	void OnTriggerEnter (Collider oser) {
		if (oser.gameObject.tag == "Player") {
			Destroy (gameObject);
		}
	}
}
