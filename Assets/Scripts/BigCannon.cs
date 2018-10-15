// @author Mohammad T. Sarker
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCannon : MonoBehaviour {

	// Use this for initialization
	public GameObject Bolts;
	AudioSource audioData;

	void Start () {
		audioData = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
		

			getInput ();
	}

	void getInput(){

		if (Input.GetKeyDown (KeyCode.P)) {
			Instantiate (Bolts, transform.position, Quaternion.identity);
			audioData.Play ();
		}
			
	}

}