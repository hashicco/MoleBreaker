using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RankingController : MonoBehaviour {
	BaseController baseController;
	public TextRankingScore[] uiTextRankingScores;

	// Use this for initialization
	void Start () {
		baseController = GameObject.Find ("BaseController").GetComponent<BaseController> ();
	}
	
	// Update is called once per frame
	void Update () {
		int[] topScores = baseController.GetTopScores ();
		for (int index = 0; index < 3; index++) {
			uiTextRankingScores[index].SetRankingScore (index, topScores [index]);
		}
	}

	public void TransitionToTitleScene()
	{
		SceneManager.LoadScene("Title");
	}

}
