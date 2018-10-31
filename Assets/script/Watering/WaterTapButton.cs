using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterTapButton : MonoBehaviour {

    public GameObject water;
    public GameObject canvasA;
    public GameObject canvasB;
    private GameObject spawnedEffect;
    private ParticleSystem ps;
	private Slider slide;
	private int slValue = 0;

	public bool isOn = false;

	void Start(){
		slide = water.GetComponent<Slider> ();
		slide.value = slValue;
	}

	public void tap()
    {
        if (!isOn) {
            //spawnedEffect = (GameObject)Instantiate(water, water.transform.position, water.transform.rotation);
			water.SetActive(true);
			StartCoroutine(tButton());
            isOn = true;
        }
        else
        {
            

            /*ps = water.GetComponent<ParticleSystem>();
            var main = ps.main;
            main.loop = false;*/
			StopAllCoroutines();
            Invoke("waitstuff", 2);

            
        }
    }

	private IEnumerator tButton(){
		while (true) {
			yield return new WaitForSeconds (0.01f);
			slValue++;
			slide.value = slValue;
		}
	}

    void waitstuff()
    {
        //Destroy(spawnedEffect);
		water.SetActive(false);
        isOn = false;
        canvasA.SetActive(false);
        canvasB.SetActive(true);
    }
    
}
