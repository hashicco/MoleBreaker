﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void TransitionToGameScene()
	{
		SceneManager.LoadScene("Game");
	}

	public void TransitionToRankingScene()
	{
		SceneManager.LoadScene("Ranking");
	}
}
