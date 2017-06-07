using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This is the PowerUp script it controls the single power up in the scene. creating a push back effect on the enemies to keep them to a distance. It is only actived if the play shoots it though.
/// </summary>
public class PowerUp : MonoBehaviour {

	public GameObject powerUpBox;				//The cube gameobject that is that hold the powerup script
	public Transform bulletSpawnPoint;			//The bullet spawn point on the end of the gun where the particle effect will play from
	public GameObject laser;					//The particle effect gameobject



	//The script below states that when the collider on the bullet shot from the gun enters the collider attached to the cube in the scene with this power up script on it. It will activate a particle effect
	//that will push back the enemies from the player.

	void OnTriggerEnter (Collider other) {

		if (other.tag == "bullet") {

			GameObject GO = Instantiate (laser, bulletSpawnPoint.position, Quaternion.identity) as GameObject;

			Destroy (laser.gameObject);

		}

	}

}
