using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager1 : MonoBehaviour {

	public GameObject timer;

	public GameObject soil;

	public GameObject gameUI;

	public GameObject buttonUI;

	bool notwin=true;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(timer.GetComponent<Timer>().timeLeft==0)
		{
			gameUI.SetActive(false);
			if(notwin==true)
			{
				if(soil.GetComponent<soil>().treeOnGround==true)
				{
					PlayerPrefs.SetInt("gameSuccess",PlayerPrefs.GetInt("gameSuccess",0)+1);
					Debug.Log("Jumlah Kemenangan"+PlayerPrefs.GetInt("gameSuccess",0));
					notwin=false;
				}
			}
			buttonUI.SetActive(true);
		}

		
		

		
	}
}
