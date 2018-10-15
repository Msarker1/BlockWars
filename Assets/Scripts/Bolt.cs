// @author Mohammad T. Sarker
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt : MonoBehaviour {

	// Use this for initialization
	public float speed;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.up*speed;
	}
	// Update is called once per frame
	void Update () {
		checkBoundries ();
	}

	void checkBoundries(){
		transform.eulerAngles = new Vector3 (0.0f, 0.0f, 0.0f);



		if (transform.localPosition.y > 13.0f || transform.localPosition.y < -13.0f) 
			Destroy (gameObject);
		if (transform.localPosition.x > 15.0f || transform.localPosition.x < -15.0f) 
			Destroy (gameObject);
		//if (transform.localPosition.z != 4.0f)
			//transform.position = new Vector3 (0, 0, 0);
	}
}
