// @author Mohammad T. Sarker
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	// Use this for initialization
	public string levelName;
	AudioSource a;
	void Start(){
		a = GetComponent<AudioSource> ();
	}
	public void loadLevel(){
		a.Play ();
		SceneManager.LoadScene (levelName);
	}

}
