using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watermeter : MonoBehaviour {

    public GameObject button;
	public GameObject effect;
	public GameObject pointer;
    public GameObject spawnedEffect;
    public bool count = false;
    public bool isGreen =false;
    Vector2 pointerpos;
	public float speed;
	bool isright;
    void Start () {
		isright=true;
	}
	
	void Update () {
        if(!count)
		moving();
		
			
		
	}

	void moving()
	{
		if(isright==true)
			pointer.transform.Translate(Vector2.right*speed*Time.deltaTime);
		else if(isright==false)
			pointer.transform.Translate(Vector2.left*speed*Time.deltaTime);
	}


	void OnTriggerEnter2D(Collider2D col)
	{
        if (col.CompareTag("boundary") && isright == true)
        {
            isright = false;
            //speed = speed * 1.3f;
        }
        else if (col.CompareTag("boundary") && isright == false)
        {
            isright = true;
            //speed = speed * 1.3f;
        }
        /*else if (col.CompareTag("greenarea") && count)
        {
            Destroy(spawnedEffect);
            count = false;
        }*/
    }

    void OnTriggerStay2D(Collider2D col) {
        if (Input.GetMouseButtonDown(0))
        {
            spawnedEffect = (GameObject)Instantiate(effect, effect.transform.position, effect.transform.rotation);
            count = true;
            Debug.Log("Cleared, next level");
            if (col.CompareTag("greenarea")) isGreen = true;
            Destroy(spawnedEffect,2f);  
            button.SetActive(true);
        }
        
    }
    

}
