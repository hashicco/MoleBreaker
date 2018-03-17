using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextResultScore : TextBase {
	public void SetScore(int score)
	{
		SetText ("Result : " + score.ToString ("0000000000"));
	}
}
