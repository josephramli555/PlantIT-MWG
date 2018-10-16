using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchtest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount>0)
		{
			foreach(Touch touch in Input.touches)
			{
				Debug.Log(touch.position);
			}
		}
	}
}
