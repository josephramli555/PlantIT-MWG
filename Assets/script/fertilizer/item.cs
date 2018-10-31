using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class item : MonoBehaviour,IPointerClickHandler{

	public GameObject manager;
	public int index;

	
	public bool answer;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

			public void OnPointerClick(PointerEventData data)
			{
				if(answer==true)
				{
					Debug.Log(answer==true);
					manager.GetComponent<fertilizermanager>().rightAnswer++;
				}

			manager.GetComponent<fertilizermanager>().hideanswer(index);
			manager.GetComponent<fertilizermanager>().clickedNumber++;
			}
		// public  void OnPointerClick(PointerEventData data)
    	// {
		// 	if(answer==true)
		// 	{
		// 		Debug.Log(answer==true);
		// 		manager.GetComponent<fertilizermanager>().rightAnswer++;
		// 	}

		// 	manager.GetComponent<fertilizermanager>().hideanswer(index);
		// 	manager.GetComponent<fertilizermanager>().clickedNumber++;
	
    	// }
		public  void OnMouseDown()
	    {
			if(answer==true)
			{
				Debug.Log(answer==true);
				manager.GetComponent<fertilizermanager>().rightAnswer++;
			}

			manager.GetComponent<fertilizermanager>().hideanswer(index);
			manager.GetComponent<fertilizermanager>().clickedNumber++;
	
    	}

	
}
