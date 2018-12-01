using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScore : MonoBehaviour {

    public GameObject wm;
    public GameObject wtb;
    public bool isUpdated;

	// Use this for initialization
	void Start () {
        isUpdated = false;
	}

    void Update() {
        if (wtb.GetComponent<WaterTapButton>().slValue >= 60 && wtb.GetComponent<WaterTapButton>().slValue <= 80 && wm.GetComponent<watermeter>().isGreen && !isUpdated)
        {
            PlayerPrefs.SetInt("gameSuccess", PlayerPrefs.GetInt("gameSuccess", 0) + 1);
            isUpdated = true;
            }
        }

	
}
