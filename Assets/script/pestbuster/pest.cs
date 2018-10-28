using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class pest : MonoBehaviour,IPointerClickHandler
{

	// Use this for initialization
	void Start () {
		
	}

    //update is called once per frame
    //void update () {
    //	if(input.getmousebuttondown(0))
    //       {
    //           var touch = input.touches[0];
    //           ray ray = camera.main.screenpointtoray(touch.position);
    //           raycasthit hit;
    //           if(physics.raycast(ray, out hit))
    //           {
    //               gameobject go = hit.collider.gameobject;
    //               destroy(go);
    //           }
    //       }
    //}


    public void OnPointerClick(PointerEventData data)
    {
        Debug.Log("Kontol gamenya anjing");
        Destroy(this.gameObject);

    }
}
