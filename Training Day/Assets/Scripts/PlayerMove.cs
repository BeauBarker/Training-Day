using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMove : MonoBehaviour {

	public Transform target;
	public Transform target2;

	Vector3 destination;

	NavMeshAgent agent;


	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		destination = agent.destination;
	}

	void Update () {

		if (Vector3.Distance (destination, target.position) > 1.0f) {
			destination = target.position;
			agent.destination = destination;
		}



	}


}
