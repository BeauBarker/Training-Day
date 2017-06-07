using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This script controlls both the raycast from the gun and the bullets that are fired from it.
/// </summary>
public class RaycastShoot : MonoBehaviour {


	public float bulletSpeed;					//bulletSpeed is the speed in which the bullet will travel

	public GameObject bulletPrefab;				//bulletPrefab is the bullet itself that will spawn
	public GameObject gunEnd;					//gunEnd is the end of the barrel of the gun where the bulletPrefab will spawn

	public Transform bulletSpawnPoint;			//bulletSpawnPoint is the point where the bulletPrefab will spawn

	public float distanceOfRay;					//distanceOfRay is the distance the Raycast will spread froward

	void Update () {

		//The lines of code below states the raycasting hits as well as the distance of the raycast. If the player presses the left mouse button the gun will fire a small bullet.
		//if the raycast hits an enemy tagged as "Target" it will destroy that enemy.

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
			
		//This will spawn a bulletPrefab at the end of the gun barrel and push it forward with a force everytime the player presses the left ouse button.


			if (Input.GetMouseButtonDown (0)) {
				GameObject GO = Instantiate (bulletPrefab, bulletSpawnPoint.position, Quaternion.identity) as GameObject;
				GO.GetComponent<Rigidbody> ().AddForce (gunEnd.transform.forward * bulletSpeed, ForceMode.Impulse);

			}



		}




	}

