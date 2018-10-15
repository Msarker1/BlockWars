// @author Mohammad T. Sarker
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour{

	// Use this for initialization

	public GameObject explosion;
	private GameObject player;

	void Start () {
		player = GameObject.Find ("BlockShip_1");

	}

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag=="Player")
			player.GetComponent<Player> ().destroyedParts (collision.gameObject.name);
		Instantiate (explosion,transform.position, Quaternion.identity);
		Destroy (gameObject);
		Destroy (collision.gameObject);


	}




}
