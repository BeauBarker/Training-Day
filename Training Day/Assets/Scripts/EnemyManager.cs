using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// This script is placed on all the enemies and is responsible for their movement in hunting the player and their deaths.
/// </summary>

public class EnemyManager : MonoBehaviour {

	public Transform Player;				//Player is the player camera the enemies will move towards
	private NavMeshAgent NMA;				//NMA is the NavMesh agent the Enemy will use to move around the map
	public Text eattenText;					//eattenText is the text displayed when the player is touched by an enemy. It will display "You have been Eaten"
	private Rigidbody rigidbody;			//rigidbody is the rigidbody placed on the enemie prefabs



	void Update () {
		NMA = GetComponent<NavMeshAgent> ();
		NMA.destination = Player.position;


	}

	void OnTriggerEnter (Collider other) {

		// if the enemy character enters the players collider then a text will appear on the screen telling the player "they have been eaten" 
		// and it will force them to restart the level.

		if (other.tag == "Player") {

			eattenText.enabled = true;
			SceneManager.LoadScene ("Main", LoadSceneMode.Single);

		}

		//For ths. if the collider on the bullet hits the collider on the enemy it will destroy the enemy.

		if (other.tag == "bullet") {

			Destroy (this.gameObject);

		}


	}

		
}
