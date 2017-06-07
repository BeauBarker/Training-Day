using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// This is the game manager script. It's purpose is to hold the win and lose condictions and well as any timers or counters that are in the scene.
/// </summary>

public class GameManager : MonoBehaviour {


	public float timeLeft = 30f;			//Store the time and the time left counting down from 30
	public Text winnerText;					//The text that says "You have Won"
    public Text loserText;					//The text that says "You have Lost"
	public Text text;						//The text that will show the number on the counter counting down.



	void Update () {


		Debug.Log (GameObject.FindGameObjectsWithTag ("Target").Length);

		//This code counts down a timer, starting at 30 seconds and counting down in seconds. Once the time reaches 0 it will display a text "You have Lost" then restart bacl to the menu.
		timeLeft -= Time.deltaTime;
		text.text = "Time Left:" + timeLeft;
		if (timeLeft < 0) {
			Debug.Log ("You Lose");

			loserText.enabled = true;
		

			SceneManager.LoadScene ("Main", LoadSceneMode.Single);
		}
		//This line of code with scan the scene and look if there are any enemies left marked as targets. If it returns that there are no more eneimes it will display the text "You have Won" then restart back to the menu.
			if (GameObject.FindGameObjectsWithTag ("Target").Length == 0) {
				Debug.Log ("Winner");

			winnerText.enabled = true;


			SceneManager.LoadScene ("Main", LoadSceneMode.Single);

		}
	}
		

}
