using System.Collections;
using System.Collections.Generic;

public class TextTimeScript : TextBase {
	public void SetTime(float time)
	{
		SetText ("Time : " + time.ToString ("F2"));
	}
}
