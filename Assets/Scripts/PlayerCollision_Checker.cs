// @author Mohammad T. Sarker
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision_Checker : MonoBehaviour{

	// Use this for initialization
	private GameObject player;

	void Start () {
		player = GameObject.Find ("BlockShip_1");
	}
	
	// Update is called once per frame
	void OnCollisionEnter(Collision collision){
		

		if (collision.gameObject.tag == "PowerUp") {
			Destroy (collision.gameObject);
			player.GetComponent<Player> ().powerUp ();


		}

		if (collision.gameObject.tag == "SuperPowerUp") {
			Destroy (collision.gameObject);
			player.GetComponent<Player> ().super = true;
			player.GetComponent<Player> ().SuperpowerUp ();
			player.transform.eulerAngles = new Vector3 (0.0f, 0.0f, 0.0f);


		}
	}

}
