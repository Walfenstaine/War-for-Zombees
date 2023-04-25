using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenInput : MonoBehaviour {
	private Muwer muw;

	void Start () {
		muw = GetComponent<Muwer> ();
	}
	void Update () {
		muw.muve = new Vector3 (Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
	}
}
