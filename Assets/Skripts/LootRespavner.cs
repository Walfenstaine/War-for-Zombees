using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootRespavner : MonoBehaviour {
	public bool dan;
	public GameObject loot, hillka;
	public int food{get; set;}
	public int hillk{get; set;}
	public static LootRespavner rid {get; set;}
	private Vector3 point;

	void Awake(){
		food = 7;
		hillk = 7;
		if (rid == null) {
			rid = this;
		} else {
			Destroy (this);
		}
	}
	void OnDestroy(){
		rid = null;
	}

	public void Serching(){
		RaycastHit hit;
		Ray ray = new Ray (new Vector3 (Random.Range(-45.0f,45.0f),15,Random.Range(-45.0f,45.0f)), Vector3.down);
		if (Physics.Raycast (ray, out hit)) {
			if (hit.collider.tag == "Grund") {
				point = hit.point;
				dan = true;
			} else {
				dan = false;
			}
		}
	}

	void Update () {
		if (hillk > 0) {
			Serching ();
			if (dan) {
				Instantiate (hillka, point, Quaternion.identity);
				hillk -= 1;
			}
		}
		if (food > 0) {
			Serching ();
			if (dan) {
				Instantiate (loot, point, Quaternion.identity);
				food -= 1;
			}
		}
	}
}
