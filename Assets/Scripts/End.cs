// @author Mohammad T. Sarker
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour {

	// Use this for initialization
	AudioSource a;

	void Start(){
		a = GetComponent<AudioSource> ();
	}
	public void quitGame(){
		a.Play ();
		Application.Quit ();
	}
}
