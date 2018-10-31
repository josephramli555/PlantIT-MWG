using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class drag : MonoBehaviour
{
    public float speed;
    public float offset;

    public Vector3 startPos;
    public bool isDragged = false;
    private Vector3 inputPosition;

    public bool isGrounds;
    void Start()
    {
        offset += 10;
        startPos=transform.position;
        isGrounds=false;
    }

    void Update()
    {

        Cursor.lockState = CursorLockMode.Confined;
        inputPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Debug.Log (isDragged);

        if (Input.GetMouseButtonUp(0))
        {
            isDragged = false;
            //gameObject.GetComponent<MeshRenderer>().enabled = false;
            if(isGrounds==false)
                transform.position=startPos;
        }

        if (Input.GetMouseButtonDown(0) && ((inputPosition - transform.position).magnitude <= offset))
        {
            //gameObject.GetComponent<MeshRenderer>().enabled = true;
            if (!isDragged)
                isDragged = true;
        }

        if (isDragged)
            transform.position = Vector2.Lerp(transform.position, inputPosition, speed);
    }

    void OnTriggerEnter(Collider other)
    {
       // Debug.Log("GAME SUKSES");
    }
}
