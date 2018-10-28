using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soil : MonoBehaviour {

	// Use this for initialization

	public GameObject treePosition;
	public bool treeOnGround;
	void Start () {
		treeOnGround=false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	

	void OnCollisionStay2D(Collision2D col)
	{
		if(col.collider.gameObject.tag=="tree")
		{
			col.collider.GetComponent<tree>().collision=true;
			if(!col.collider.GetComponent<tree>().dragging)
			{
				col.collider.gameObject.transform.position=treePosition.transform.position;
				treeOnGround=true;
			}
		}
	}

	
	void OnCollisionExit2D(Collision2D col)
	{
			col.collider.GetComponent<tree>().collision =false;
	}
}
