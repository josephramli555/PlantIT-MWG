using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmanager : MonoBehaviour {

	public string levelToLoad;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void changelevel()
	{
		SceneManager.LoadScene(levelToLoad);
	}
}
