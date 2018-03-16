using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTimeScript : MonoBehaviour {
	private float time;

	// Use this for initialization
	void Start () {		
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = "Time : " + time.ToString("F2");
	}

	public void SetTime(float time)
	{
		this.time = time;
	}

}
