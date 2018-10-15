// @author Mohammad T. Sarker
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBolt : MonoBehaviour {
	private float speed = 25.0f;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.up*speed*-1;
	}
	
	// Update is called once per frame
	void Update () {
		checkBoundries ();
	}

	void checkBoundries(){
		transform.eulerAngles = new Vector3 (0.0f, 0.0f, 0.0f);
		if (transform.localPosition.y > 13.0f || transform.localPosition.y < -13.0f) 
			Destroy (gameObject);
		if (transform.localPosition.x > 13.0f || transform.localPosition.x < -13.0f) 
			Destroy (gameObject);
	}
}
