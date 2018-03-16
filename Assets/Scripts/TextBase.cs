using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBase : MonoBehaviour {
	private string text;

	// Use this for initialization
	void Start () {		
		this.text = "";
	}

	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = this.text;
	}

	public void SetText(string text)
	{
		this.text = text;
	}

}
