using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameResultController : MonoBehaviour {
	GameController gameController;
	int currentScore;

	// Use this for initialization
	void Start () {
		gameController = GameObject.Find ("GameController").GetComponent<GameController> ();
		currentScore = gameController.GetCurrentScore ();
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	public void TransitionToTitleScene()
	{
		SceneManager.LoadScene("Title");
	}

	public void TransitionToGameScene()
	{
		SceneManager.LoadScene("Game");
	}

}
