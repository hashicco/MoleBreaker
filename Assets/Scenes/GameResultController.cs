using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameResultController : MonoBehaviour {
	GameController gameController;
	int resultScore;
	bool isHighScore = true;

	public TextResultScore uiTextResultScore;
	public TextHighScoreNotice uiTextHighScoreNotice;

	// Use this for initialization
	void Start () {
		gameController = GameObject.Find ("GameController").GetComponent<GameController> ();
		resultScore = gameController.GetCurrentScore ();
		isHighScore = gameController.IsHighScore ();
		if(!isHighScore)
			uiTextHighScoreNotice.Hide ();
	}
	
	// Update is called once per frame
	void Update () {
		uiTextResultScore.SetScore(resultScore);
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
