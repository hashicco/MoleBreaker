using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	private bool isFinished;
	private bool isResultOpened;
	private bool isControllable;
	private float defaultRestTime = 60.0F;
	private float uncontrollableTime = 1.0F;
	private float restTime;
	private int currentScore;
	private int highScore;
	private bool isHighScore;

	BaseController baseController;

	TextTimeScript uiTextTime;
	TextCurrentScoreScript uiTextCurrentScore;
	TextHighScoreScript uiTextHighScore;

	// Use this for initialization
	void Start () 
	{
		isFinished = false;
		isResultOpened = false;
		isControllable = false;
		restTime = defaultRestTime;

//		baseController = GameObject.Find ("BaseController").GetComponent<BaseController> ();
//		highScore = baseController.GetHighScore ();
		highScore = 0;
		currentScore = 0;
		isHighScore = false;

		uiTextTime = GameObject.Find ("TextTime").GetComponent<TextTimeScript> ();
		uiTextCurrentScore = GameObject.Find ("TextCurrentScore").GetComponent<TextCurrentScoreScript> ();
		uiTextHighScore = GameObject.Find ("TextHighScore").GetComponent<TextHighScoreScript> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		uiTextTime.SetTime (restTime);
		uiTextCurrentScore.SetScore (currentScore);
		uiTextHighScore.SetScore (highScore);

		PlayerControl ();

		CheckHighScore ();
		CheckRestTime ();
	}
		
	public int AddScore(int score){
		currentScore+= score;
		return currentScore;
	}
		
	void PlayerControl()
	{
		if (isControllable && Input.GetMouseButtonDown (0)) {
			var hammer = Resources.Load ("Prefabs/Player/Hammer");

			Vector3 screenPos = Input.mousePosition;
			Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);

			var hammerInstance = Instantiate (hammer, worldPos, Quaternion.identity) as GameObject;
			Destroy(hammerInstance, 0.8f);
		}
	}


	void CheckRestTime()
	{
		restTime -= Time.deltaTime;
		if (restTime < 0.0F) {
			restTime = 0.0F;
		}

		if (restTime < defaultRestTime - uncontrollableTime) {
			isControllable = true;
		}

		if (restTime == 0.0F) {
			FinishGame ();
		}
	}

	void CheckHighScore()
	{
		if (currentScore > highScore) {
			highScore = currentScore;
			isHighScore = true;
		}
	}

	void FinishGame()
	{
		if (!isFinished) {
			isFinished = true;
			isControllable = false;
			OpenGameResultScene ();
		}
	}

	void OpenGameResultScene()
	{
		if (!isResultOpened) {
			isResultOpened = true;
			SceneManager.LoadScene ("GameResult", LoadSceneMode.Additive);
		}
	}

	public int GetCurrentScore()
	{
		return this.currentScore;
	}

	public bool IsHighScore()
	{
		return this.isHighScore;
	}

}
