// @author Mohammad T. Sarker
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMiddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Bolts")
			Destroy (transform.parent.gameObject);
	}
}
