using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour {

public GameObject soil;
public GameObject timer;

public GameObject GameplayUI;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(timer.GetComponent<Timer>().timeLeft<=0)
		{
			if(soil.GetComponent<soil>().treeOnGround==true)
			{
				PlayerPrefs.SetInt("gameSuccess",PlayerPrefs.GetInt("gameSuccess",0)+1);
			}

			
		}
	}
}
