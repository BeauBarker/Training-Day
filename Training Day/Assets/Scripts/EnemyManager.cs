using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class EnemyManager : MonoBehaviour {

	public Transform Player;
	private NavMeshAgent NMA;
	public Text eattenText;



	void Update () {
		NMA = GetComponent<NavMeshAgent> ();
		NMA.destination = Player.position;


	}

	void OnTriggerEnter (Collider other) {

		if (other.tag == "Player") {

			//Destroy (other.gameObject);

			eattenText.enabled = true;

		}

		if (other.tag == "bullet") {

			Destroy (this.gameObject);

		}


	}

		
}
