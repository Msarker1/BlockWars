// @author Mohammad T. Sarker
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Level_2 : MonoBehaviour {
	public GameObject []  Rocks;
	public GameObject PowerUp;
	public GameObject LevelUp;
	public GameObject player;
	public GameObject pause;
	public List <GameObject> enemySmall;
	private GameObject enemyRef;


	float timer = -5.0f;
	float pTimer = 0.0f;
	float level_timer = 0.0f;
	float enemy_timer = 0.0f;
	bool paused = false;
	bool isDead = false;

	void Start(){
		Time.timeScale = 1.0f;
		player = GameObject.Find ("BlockShip_1");
	}
	// Update is called once per frame
	void Update () {
		float x = Random.Range (-15.0f, 15.0f);
		float y = Random.Range (10.0f, 12.0f);
		float z = 4.0f;
		Vector3 pos = new Vector3 (x, y, z);
		int element = Random.Range (0, 2);
		level_timer += 0.01f;
		enemy_timer += 0.01f;
		isAlive ();

		if((!isDead) && (!loadLevelUp())){
			loadRocks (element, pos);
			loadpowerUp (pos);
		}
		if(loadLevelUp())
			levelUp();

		if (enemy_timer >= 12.5f) {
			enemy_timer = 6.25f;
			loadenemySmall ();
		}

		if (pause.activeSelf)
			paused = true;
		else
			paused = false;

	

	}
	void isAlive(){
		//Debug.Log (isDead);
		if (player == null) {
			isDead = true;
			Time.timeScale = 0.0f;
			paused = true;
		}
	}

	bool loadLevelUp(){ 
		if ((level_timer >= 75.0f) && (enemyRef==null)) //60 seconds 0.625 per second real time
			return true;
		return false;
	}
	void levelUp(){
		LevelUp.SetActive (true);
	}

	void loadRocks(int element,Vector3 pos){
		timer += Time.deltaTime;
		if(Mathf.Round(timer)==2.0f){
			Instantiate (Rocks[element],pos, Quaternion.identity);
			timer = 0.0f;
		}

	}

	void loadpowerUp(Vector3 pos){
		//Debug.Log (player.GetComponent<Player> ().missingParts.Count);
		if (player != null) {
			if (player.GetComponent<Player> ().missingParts.Count > 0)
				pTimer += Time.deltaTime;
			if (Mathf.Round (pTimer) == 10.0f) {
				Instantiate (PowerUp, pos, Quaternion.identity);
				pTimer = 0.0f;
			}
		}
	}


	void loadenemySmall(){
		if (enemySmall.Count> 0  &&(!paused)) {
			enemyRef = Instantiate (enemySmall[0]);
			enemySmall.RemoveAt (0);


		}
	}


}
