using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour {
	public static int current_score = 0;
	public static int high_score = 0;
	public static int[] top_scores = new int[10];

	// Use this for initialization
	void Start () {
//		DontDestroyOnLoad(this);
		Application.LoadLevelAdditive("Title");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
