using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	private bool isFinished = false;
	private bool isResultOpened = false;
	private int restTime = 0;

	// Use this for initialization
	void Start () {
		isFinished = false;
		isResultOpened = false;
		restTime = 10;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (!isFinished) {
				Finish ();
			}
		}

		if (isFinished && !isResultOpened) {
			OpenGameResultScene ();
		}
	}

	void Finish(){
		isFinished = true;
	}

	public void OpenGameResultScene()
	{
		isResultOpened = true;
		SceneManager.LoadScene("GameResult", LoadSceneMode.Additive);
	}
}
