// @author Mohammad T. Sarker
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instructions : MonoBehaviour {

	// Use this for initialization
	AudioSource a;

	void Start(){
		a = GetComponent<AudioSource> ();
	}

	public void loadMenu(){
		SceneManager.LoadScene ("Menu");
	}
	public void playAudio(){
		a.Play ();
	}
}
