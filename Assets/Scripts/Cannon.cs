// @author Mohammad T. Sarker
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {

	// Use this for initialization
	public GameObject Bolts;
	private GameObject supermode = null;
	AudioSource audioData ;
	float timer = 0.0f;
	bool super = false;

	void Start () {
		audioData = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!super)
			getInput ();
		else
			getInputSuper ();
		supermode = GameObject.FindWithTag ("SuperMode");

		if (supermode != null)
			super = true;
		else {
			super = false;
			GameObject.Find ("BlockShip_1").GetComponent<Player> ().super = false;
		}
	}

	void getInput(){
		if (Input.GetKeyDown (KeyCode.P)) {
			Instantiate (Bolts, transform.position, Quaternion.identity);
			audioData.Play ();
		}
	}

	void getInputSuper(){
		timer += Time.deltaTime;	
		if(Mathf.Round(timer)==1.0f){
			Instantiate (Bolts, transform.position, Quaternion.identity);
			audioData.Play ();
			timer = 0.0f;
		}
	}


}
