// @author Mohammad T. Sarker
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	AudioSource a;

	void Start(){
		a = GetComponent<AudioSource> ();
	}
	public void loadGame(){
		SceneManager.LoadScene ("Level_1");		
	}

	public void loadControls(){
		SceneManager.LoadScene ("Controls");		
	}

	public void loadInstructions(){
		SceneManager.LoadScene ("Instructions");		
	}

	public void playAudio(){
		a.Play ();
	}

	public void quitGame(){
		Application.Quit ();
	}
}
