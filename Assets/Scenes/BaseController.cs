using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseController : MonoBehaviour {
	static int topScoresNum = 3;

	int highScore = 0;
	int[] topScores = new int[topScoresNum];

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this);
		SceneManager.LoadScene("Title", LoadSceneMode.Additive);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public int GetHighScore()
	{
		return this.highScore;
	}

	public void UpdateTopScores(int score)
	{
		int[] tempTopScores = new int[topScoresNum + 1];

		for (int index = 0; index < topScoresNum; index++) {
			tempTopScores [index] = topScores [index];
		}			
		tempTopScores[topScoresNum] = score;
		Array.Sort (tempTopScores);
		Array.Reverse (tempTopScores);

		for (int index = 0; index < topScoresNum; index++) {
			topScores [index] = tempTopScores [index];
		}

		this.highScore = topScores [0];
	}

}
