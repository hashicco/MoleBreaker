using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextRankingScore : TextBase {
	public void SetRankingScore(int rank, int score){
		switch(rank)
		{
		case 0:
			SetText ("1st : " + score.ToString ("0000000000"));
			break;
		case 1:
			SetText ("2nd : " + score.ToString ("0000000000"));
			break;
		case 2:
			SetText ("3rd : " + score.ToString ("0000000000"));
			break;
		}

	}
}
