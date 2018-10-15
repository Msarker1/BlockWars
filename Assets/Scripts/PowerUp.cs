// @author Mohammad T. Sarker
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

	// Use this for initialization
	private Rigidbody rb;
	float speed = 2.0f;


	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.up * speed * -1;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime*2.0f);
	
		checkBoundries ();
	
	}

	void checkBoundries(){
		if (transform.localPosition.y > 13.0f || transform.localPosition.y < -13.0f) 
			Destroy (gameObject);
		if (transform.localPosition.x > 13.0f || transform.localPosition.x < -13.0f) 
			Destroy (gameObject);
	}
}
