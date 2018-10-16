using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTapButton : MonoBehaviour {

    public GameObject water;
    public GameObject canvasA;
    public GameObject canvasB;
    private GameObject spawnedEffect;
    private ParticleSystem ps;


    private bool isOn = false;


	public void tap()
    {
        if (!isOn) {
            spawnedEffect = (GameObject)Instantiate(water, water.transform.position, water.transform.rotation);
            isOn = true;
        }
        else
        {
            

            ps = water.GetComponent<ParticleSystem>();
            var main = ps.main;
            main.loop = false;

            Invoke("waitstuff", 2);

            
        }
    }

    void waitstuff()
    {
        Destroy(spawnedEffect);
        isOn = false;
        canvasA.SetActive(false);
        canvasB.SetActive(true);
    }
    
}
