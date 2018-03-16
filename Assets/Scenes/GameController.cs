using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	private bool isFinished;
	private bool isResultOpened;
	private float restTime;
	private int currentScore;
	private int highScore;

	GameObject uiTextTime;
	GameObject uiTextCurrentScore;
	GameObject uiTextHighScore;

	// Use this for initialization
	void Start () 
	{
		isFinished = false;
		isResultOpened = false;
		restTime = 60.0F;
		currentScore = 0;

		uiTextTime = GameObject.Find ("TextTime");
	}
	
	// Update is called once per frame
	void Update () 
	{
		UpdateRestTime ();
		UpdateCurrentScore ();
		UpdateHighScore ();

		CheckRestTime ();
	}

	void UpdateRestTime()
	{
		restTime -= Time.deltaTime;
		if (restTime < 0.0F) {
			restTime = 0.0F;
		}

		uiTextTime.GetComponent<TextTimeScript>().SetTime (restTime);
	}

	void UpdateCurrentScore()
	{

	}

	void UpdateHighScore()
	{

	}

	void CheckRestTime()
	{
		if (restTime == 0.0F) {
			FinishGame ();
		}
	}

	void FinishGame()
	{
		if (!isFinished) {
			isFinished = true;
			OpenGameResultScene ();
		}
	}

	public void OpenGameResultScene()
	{
		if (!isResultOpened) {
			isResultOpened = true;
			SceneManager.LoadScene ("GameResult", LoadSceneMode.Additive);
		}
	}
}
