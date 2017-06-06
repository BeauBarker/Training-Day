using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShoot : MonoBehaviour {

	public GameObject death;
	public float bulletSpeed;

	public GameObject bulletPrefab;
	public GameObject gunEnd;

	public Transform bulletSpawnPoint;

	public float distanceOfRay;

	void Update () {

		RaycastHit hit;

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		float distanceOfRay = 300;

		if (Physics.Raycast (ray, out hit, distanceOfRay)) {
			Debug.Log (hit.transform.name);

			if (Input.GetMouseButtonDown (0)) {

				if (hit.collider.tag == "Target") {


					Destroy (hit.collider.gameObject);
				

				}
				
			  }

			}
			

			if (Input.GetMouseButtonDown (0)) {
				GameObject GO = Instantiate (bulletPrefab, bulletSpawnPoint.position, Quaternion.identity) as GameObject;
				GO.GetComponent<Rigidbody> ().AddForce (gunEnd.transform.forward * bulletSpeed, ForceMode.Impulse);

			}



		}




	}

