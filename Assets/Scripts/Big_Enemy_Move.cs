
// @author Mohammad T. Sarker
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Big_Enemy_Move : MonoBehaviour {

	// Use this for initialization
	private float borderX = 13.0f;
	private float movement = 4.0f;
	private float speed = 2.0f;
	private bool dir;
	float ran = 0.0f;
	void Start () {
		if (Random.value > Random.value)
			dir = true;
		else
			dir = false;
		ran= Random.Range(4,6);
	}

	// Update is called once per frame
	void Update () {

		//Debug.Log (Mathf.Round (transform.localPosition.y)+ " "+ ran );
		if (Mathf.Round (transform.localPosition.y) != ran)
			transform.Translate (0.0f, 0f, 0.1f);

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
