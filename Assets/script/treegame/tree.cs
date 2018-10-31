using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour {

	public bool dragging=false;
	public bool collision=false;
	Vector3 position;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void beginDrag()
	{
		position=gameObject.transform.position;
		dragging=true;
	}

	public void drag()
	{
		transform.position=Input.mousePosition;
	}


	public void drop()
	{
		if(!collision)
		{
			gameObject.transform.position=position;

		}
		dragging=false;
	}
}
