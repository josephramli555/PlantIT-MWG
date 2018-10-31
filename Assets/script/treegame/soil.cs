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

	


	void OnTriggerEnter(Collider col)
	
	{
		if(col.gameObject.tag=="tree")
		{
			col.GetComponent<drag>().isGrounds=true;
			
				col.GetComponent<drag>().enabled=false;
				col.transform.position=treePosition.transform.position;
				treeOnGround=true;
			
		}
	}

	

}
