﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameResultController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
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