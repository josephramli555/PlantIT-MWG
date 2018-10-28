using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class test : MonoBehaviour
{
    public float speed;
    public float offset;

    private bool isDragged = false;
    private Vector3 inputPosition;

    void Start(){
		//speed = 2;	
        offset += 10;
    }

    void Update(){

        Cursor.lockState = CursorLockMode.Confined;
        inputPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Debug.Log (isDragged);

        if (Input.GetMouseButtonUp(0))
        {
            isDragged = false;
            //gameObject.GetComponent<MeshRenderer>().enabled = false;
        }

        if (Input.GetMouseButtonDown(0) && ((inputPosition - transform.position).magnitude <= offset))
        {
           // gameObject.GetComponent<MeshRenderer>().enabled = true;
            if (!isDragged)
                isDragged = true;
            Debug.Log(" Kont");
        }

        if (isDragged)
        {
            transform.position = Vector2.Lerp(transform.position, inputPosition, speed);
            Debug.Log("lerp  jalan");
        }
    }

}
