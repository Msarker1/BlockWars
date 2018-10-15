// @author Mohammad T. Sarker
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {
	
	private float borderX = 13.0f;
	private float movement = 4.0f;
	private float speed = 1.0f;
	private bool dir= false;
	float ran = 0.0f;
	void Start () {
		if (Random.value > Random.value)
			dir = true;
		else
			dir = false;
		ran= Random.Range(5,6);
	}

	// Update is called once per frame
	void Update () {
	
		//Debug.Log (Mathf.Round (transform.localPosition.y)+ " "+ ran );
		if (Mathf.Round (transform.localPosition.y) != ran) {
			float y = transform.localPosition.y > ran ? 0.1f : -0.1f;
			transform.Translate (0.0f, y, 0.0f);


		}
		if (Mathf.Round (transform.localPosition.y) == ran) {
			ran= Random.Range(-3,10);
		}

		direction ();

		if(!dir)
			transform.Translate (speed * movement * Time.deltaTime, 0.0f, 0.0f);
		else
			transform.Translate (-1*speed * movement * Time.deltaTime, 0.0f, 0.0f);
		


	}
	void direction(){
		if(transform.position.x< -borderX)
			dir = false;
		if(transform.position.x>borderX)
			dir = true;
	}
}
