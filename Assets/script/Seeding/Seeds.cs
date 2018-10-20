using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Seeds : MonoBehaviour,IPointerClickHandler {

	

	public GameObject manager;
	public int index;
	void Start () {
			 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public  void OnPointerClick(PointerEventData data)
    {
		if(manager.GetComponent<seedmanager>().answer[index]==true)
		{
			Debug.Log("Jawaban Benar");
            manager.GetComponent<seedmanager>().seedamount--;
		}
		else if(manager.GetComponent<seedmanager>().answer[index]==false)
		{
			Debug.Log("Jawaban salah ");
            manager.GetComponent<seedmanager>().seedamount--;
        }
		
	
    }
}
