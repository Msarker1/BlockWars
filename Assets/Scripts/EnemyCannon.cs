// @author Mohammad T. Sarker
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCannon : MonoBehaviour {

	// Use this for initialization
	float timer = 0.5f;
	public GameObject EnemyBolts;
	AudioSource a;
	void Start () {
		a = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		timer -= Time.deltaTime;
		if (timer <= 0.0f) {
			a.Play ();
			Instantiate (EnemyBolts, transform.position, Quaternion.identity);
			timer = 0.5f;
		}



	}
}
