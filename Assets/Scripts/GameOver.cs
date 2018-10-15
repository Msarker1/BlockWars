// @author Mohammad T. Sarker
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	AudioSource a;
	public GameObject player;
	public GameObject menu;

	void Start () {
		a = GetComponent<AudioSource> ();

	}
	void Update(){
		if (player == null) {
			
			menu.SetActive (true);
		}

	}




	// Update is called once per frame

	public void loadMenu(){
		a.Play ();
		SceneManager.LoadScene ("Menu");
	}
}
