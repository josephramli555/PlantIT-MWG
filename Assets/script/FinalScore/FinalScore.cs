using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour {

	public Text Result;

	public Text resultScore;
	public int result;
	public string message;
	void Start () {
		result=0;
		result=PlayerPrefs.GetInt("gameSuccess",0);
		if(result==5)
			message="perfect";
		else if(result==4 || result ==3)
			message="Good";
		else if(result<=2 && result>0)
			message="Try Again";
		else if(result==0)
			message="Try Again";

			Result.text=message;	

			resultScore.text=result.ToString();

			Debug.Log(result);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
