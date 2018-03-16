using System.Collections;
using System.Collections.Generic;

public class TextHighScoreScript : TextBase {
	public void SetScore(int score)
	{
		SetText ("HighScore : " + score.ToString ("0000000000"));
	}
}
