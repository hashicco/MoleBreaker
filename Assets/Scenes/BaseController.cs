using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseController : MonoBehaviour {
	int highScore = 0;
	int[] topScores = new int[10];

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

	public int SetHighScore(int score)
	{
		this.highScore = score;
		return this.highScore;
	}

}
