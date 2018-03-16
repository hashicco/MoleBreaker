using System.Collections;
using System.Collections.Generic;

public class TextCurrentScoreScript : TextBase {
	public void SetScore(int score)
	{
		SetText ("Score : " + score.ToString ("0000000000"));
	}
}
