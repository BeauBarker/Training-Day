using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

	public float timeLeft = 30f;
	public Text winnerText;
	public Text loserText;


	void Update () {

		Debug.Log (GameObject.FindGameObjectsWithTag ("Target").Length);

		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			Debug.Log ("You Lose");

			loserText.enabled = true;
		
			//yield return new WaitForSeconds (2);
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}

			if (GameObject.FindGameObjectsWithTag ("Target").Length == 0) {
				Debug.Log ("Winner");

			winnerText.enabled = true;

			//yield return new WaitForSeconds (2);
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);

		}
	}
}
