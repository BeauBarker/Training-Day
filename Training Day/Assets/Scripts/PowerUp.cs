using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Power up.
/// </summary>
public class PowerUp : MonoBehaviour {

	public GameObject powerUpBox;
	public Transform bulletSpawnPoint;
	public GameObject laser;


	void Update () {



	}


	void OnTriggerEnter (Collider other) {

		if (other.tag == "bullet") {

			GameObject GO = Instantiate (laser, bulletSpawnPoint.position, Quaternion.identity) as GameObject;

			Destroy (laser.gameObject);

		}

	}

}
