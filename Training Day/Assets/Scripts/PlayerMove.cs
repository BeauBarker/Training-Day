using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
/// <summary>
/// This script contols the players movement. moving them along a set path.
/// </summary>
public class PlayerMove : MonoBehaviour {

	public Transform target;			//The target waypoint the player camera will move to
	Vector3 destination;				//destination is the players final point to move too
	NavMeshAgent agent;					//agent will call and use the NavMesh agaent to allow the player camera to find its way to the target waypoint

	//Once the scene begins this part of the script will use the NavMesh created in the scene

	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		destination = agent.destination;
	}

	//This update will move the player to the new destination making the player follow the Navmesh.

	void Update () {

		if (Vector3.Distance (destination, target.position) > 1.0f) {
			destination = target.position;
			agent.destination = destination;
		}



	}


}
