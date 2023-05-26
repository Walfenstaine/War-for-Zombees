using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    public Data data;
    public Equers equers;
    public enum Equers { Player, Mob }
    public string tagger = "Enemy";
    public float spector = 5.0f;
	public ParticleSystem ps;
	public float interval;
	public AudioClip clip;
	public Transform target;
	private float timer;
	private float radius;
	public LayerMask mask;

	void Start (){
	
	}
	public void Shut () {
		if (target != null) {
            RaycastHit hit;
            Ray ray = new Ray(transform.position, (target.position- transform.position));
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == tagger)
                {
                    if (hit.distance > spector)
                    {
                        target = null;
                    }
                    if (Time.timeScale > 0)
                    {
                        if (hit.collider.GetComponent<Helse>())
                        {
                            if (equers == Equers.Player)
                            {
                                hit.collider.GetComponent<Helse>().helse -= data.playerAtak;
                            }
                            else
                            {
                                hit.collider.GetComponent<Helse>().helse -= data.mobAtak;
                            }
                            SoundPlayer.regit.sorse.PlayOneShot(clip);
                            ps.Play();
                            hit.collider.GetComponent<Helse>().Damage();
                        }
                        else
                        {
                            target = null;
                        }
                    }
                    else
                    {
                        target = null;
                    }
                }
			} 
		} 
	}
	public void Serching (){
		Collider[] serch = Physics.OverlapSphere (transform.position, radius, mask);
		if (serch.Length > 0) {
			target = serch [0].transform;
		}
		if (radius < spector) {
			radius += spector * 10 * Time.deltaTime;
		} else {
			radius = 0;
		}
	}
	void Update () {
		if (timer > interval) {
			Shut ();
			timer = 0;
			radius = 0;
		}
		timer += Time.unscaledDeltaTime;
		if (target != null) {
			var lokker = transform.position - target.position;
			lokker.y = 0;
			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (lokker), 5 * Time.deltaTime);
		} else {
			Serching ();
			transform.rotation = Quaternion.Slerp (transform.rotation, transform.parent.rotation, Time.deltaTime);
		}
	}
}
