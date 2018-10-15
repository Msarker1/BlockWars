// @author Mohammad T. Sarker
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using System.Linq;

	public class Player : MonoBehaviour {
	
	public GameObject ConnectLeft_Engine;
	public GameObject ConnectLeft_Cannon;
	public GameObject ConnectRight_Engine;
	public GameObject ConnectRight_Cannon;
	public GameObject SuperMode;
	public bool access = false;
	public bool super = false;
	Dictionary<string,GameObject> parts = new Dictionary<string,GameObject> ();

	AudioSource [] Sounds;//audios turn,powerups

	//private Rigidbody rb;
	private bool spin = false;
	private float speed = 20.0f;
	private float borderX = 15.0f;
	private float movement = 6.0f;

	public List<string> missingParts = new List<string>();


	// Use this for initialization
	void Start () {
		//rb = GetComponent<Rigidbody> ();
		Sounds = GetComponents<AudioSource>();
		parts.Add("ConnectLeft_Engine",ConnectLeft_Engine);
		parts.Add("ConnectRight_Cannon",ConnectRight_Cannon);
		parts.Add("ConnectRight_Engine",ConnectRight_Engine);
		parts.Add("ConnectLeft_Cannon",ConnectLeft_Cannon);
		parts.Add ("SuperMode", SuperMode);


	}

	// Update is called once per frame
	void Update () {
		float x = transform.position.x;
		float y = transform.position.y;
		float z = transform.position.z;
		checkBoundries (x,y,z);

		if (!super){
			getInput (x, y, z);
			rotateShip ();
		}
		else
			getInputSuper();


	}
		

	bool isAlive(){
		return false;
	}
	void getInputSuper(){ 
		
		float h = Input.GetAxis ("Horizontal");
		transform.Translate(h*speed*Time.deltaTime,0.0f,0.0f);

	}
		
	void getInput(float x, float y, float z){ // input 
		if(Input.GetKeyDown(KeyCode.A)){
			spin = true;
			Vector3 playerPosition = new Vector3 (x-movement, y, z);
			transform.position = playerPosition;
			Sounds[0].Play ();

		}

		if(Input.GetKeyDown(KeyCode.D)){
			spin = true;
			Vector3 playerPosition = new Vector3 (x+movement, y, z);
			transform.position = playerPosition;
			Sounds[0].Play ();
		}





	}

	void rotateShip(){ // checks spins
		if(spin==true) 
			transform.Rotate(Vector3.up*speed);
		
		if ((spin == true) && ((Mathf.Ceil(transform.rotation.eulerAngles.y+360)) % 360.0f == 0.0f)) {
			spin = false;
		}


	}

	void checkBoundries(float x,float y,float z){ // checks boundries
		if (x <-borderX)
			transform.position = new Vector3 (-12.0f,y, z);
		if(x>borderX)
			transform.position = new Vector3 (12.0f, y, z);
	}
		




	public void destroyedParts(string g){
//		if (g.Contains ("Left") && g.Contains ("Engine")  && (!missingParts.Contains("ConnectLeft_Engine"))){
//			missingParts.Add ("ConnectLeft_Engine");
//		}
//		if (g.Contains ("Left") && g.Contains ("Cannon") && (!missingParts.Contains("ConnectLeft_Cannon"))){
//			missingParts.Add ("ConnectLeft_Cannon");
//		}
//
//		if (g.Contains ("Right") && g.Contains ("Cannon") && (!missingParts.Contains("ConnectRight_Cannon"))) {
//			missingParts.Add ("ConnectRight_Cannon");
//		}
//		if (g.Contains ("Right") && g.Contains ("Engine") && (!missingParts.Contains("ConnectRight_Engine"))) {
//			missingParts.Add ("ConnectRight_Engine");
//		}
//
		missingParts.Add("T");
	}

	public void powerUp(){ // go thru all child find the element to be replaced and instantiate new element
		if (missingParts.Count>0) {
			//int r = Random.Range (0, missingParts.Count);
			foreach (Transform child in transform)
			{	//if (child.gameObject.name == missingParts[r]) {
					Destroy (child.gameObject);
				//}
			}
			Sounds[2].Play();
			//Instantiate (parts[missingParts[r]], transform);
			Instantiate (parts["ConnectLeft_Engine"], transform);
			Instantiate (parts["ConnectLeft_Cannon"], transform);
			Instantiate (parts["ConnectRight_Engine"], transform);
			Instantiate (parts["ConnectRight_Cannon"], transform);
			//missingParts.Remove (missingParts [r]);
			//Debug.Log (missingParts.Count );
			missingParts.Clear();
			//Debug.Log (missingParts.Count + "COUNTS");


		}
			
	}


	public void SuperpowerUp(){ // go thru all child find the element to be replaced and instantiate new element
		if (missingParts.Count>0) {
			//int r = Random.Range (0, missingParts.Count);
			foreach (Transform child in transform)
			{	//if (child.gameObject.name == missingParts[r]) {
				Destroy (child.gameObject);
				//}
			}
			Sounds[3].Play();
			//Instantiate (parts[missingParts[r]], transform);
			Instantiate (parts["ConnectLeft_Engine"], transform);
			Instantiate (parts["ConnectLeft_Cannon"], transform);
			Instantiate (parts["ConnectRight_Engine"], transform);
			Instantiate (parts["ConnectRight_Cannon"], transform);
			Instantiate (parts ["SuperMode"], transform);
			//missingParts.Remove (missingParts [r]);
			Debug.Log (missingParts.Count );
			missingParts.Clear();
			Debug.Log (missingParts.Count + "COUNTS");


		}

	}




}
