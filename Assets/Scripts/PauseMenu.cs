// @author Mohammad T. Sarker
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	// Use this for initialization
	public static bool gamePaused = false;
	public GameObject menu;
	public GameObject player;
	// Update is called once per frame
	AudioSource [] a;

	void Start(){
		a = GetComponents<AudioSource> ();

	}

	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (gamePaused)
				resume ();
			else
				pause ();
		}
	}


	void pause(){
		a [0].Play ();
		gamePaused = true;
		menu.SetActive (true);
		player.SetActive (false);
		Time.timeScale = 0.0f;

	}
	public void resume(){
		gamePaused = false;
		menu.SetActive (false);
		player.SetActive (true);
		Time.timeScale = 1.0f;
		a [0].Stop ();
	}

	public void loadMenu(){
		Time.timeScale = 1.0f;
		SceneManager.LoadScene ("Menu");
	}

	public void playAudio(){
		a[1].Play ();
	}
}
