// @author Mohammad T. Sarker


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Level_5 : MonoBehaviour {


	public GameObject PowerUp;
	public GameObject LevelUp;
	public GameObject player;
	public GameObject pause;
	public GameObject enemySmall;
	public GameObject enemyBig;
	public GameObject enemyBoss;
	float gameTime = 37.5f;//60seconds


	float timer = 0.0f;
	float pTimer = 0.0f;
	float level_timer = 0.0f;
	float enemy_timer = 0.0f;
	float enemyBig_timer = 0.0f;
	float bossTimer = 0.0f;
	bool paused = false;
	bool isDead = false;

	void Start(){
		
		player = GameObject.Find ("BlockShip_1");
	}
	// Update is called once per frame
	void Update () {

		float x = Random.Range (-15.0f, 15.0f);
		float y = Random.Range (10.0f, 12.0f);
		float z = 4.0f;
		Vector3 pos = new Vector3 (x, y, z);


		if (pause.activeSelf)
			paused = true;
		else
			paused = false;
		if (!paused)
			timer += 0.01f;
		if (timer >= 6.25f && timer <= 6.26f)
			loadenemyBoss ();
		
		if (timer > 12.5f ) {
			

			if (!paused) {
				level_timer += 0.01f;
				enemy_timer += 0.01f;
				enemyBig_timer += 0.01f;
				bossTimer += 0.01f;
			}

			if (loadLevelUp ())
				levelUp ();

			if (enemy_timer >= 3.125f && (level_timer < gameTime)) {
				enemy_timer = 0.0f;
				loadenemySmall ();
			}

			if (enemyBig_timer >= 12.5f && (level_timer < gameTime)) {
				enemyBig_timer = 0.0f;
				loadenemyBig ();	
			}
			if (bossTimer > 31.25f && (level_timer < gameTime)) {
				bossTimer = 25.0f;
				loadenemyBoss ();

			}


		}



		isAlive ();

		if ((!isDead) && (!loadLevelUp ())) {

			loadpowerUp (pos);
		}

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
		if ((level_timer >= gameTime) && (GameObject.FindGameObjectsWithTag("Boss").Length==0) &&(GameObject.FindGameObjectsWithTag("Enemies").Length==0)) //60 seconds 0.625 per second real time
			return true;
		return false;
	}
	void levelUp(){
		LevelUp.SetActive (true);
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
		if ((!paused)) {
			Instantiate (enemySmall);



		}
	}

	void loadenemyBig(){
		if ((!paused)) {
			Instantiate (enemyBig);


		
		}
	}


	void loadenemyBoss(){
		if ((!paused)) {
			Instantiate (enemyBoss);



		}
	}
}
