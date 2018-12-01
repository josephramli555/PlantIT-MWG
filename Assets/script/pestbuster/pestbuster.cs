using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pestbuster : MonoBehaviour {



    public GameObject timer;

    public GameObject[] pestlist;
    public GameObject pest;
	public RectTransform panel;
    public float Maxx;
    public float Maxy;
    public float Minx;
    public float Miny;
    public bool isUpdatedScore;
    int i = 0;
  
    void Start () {

        
        isUpdatedScore=false;
        pestlist=new GameObject[5];
		Debug.Log (panel.rect.x);
		Debug.Log (panel.rect.y);
        while (i < 5)
        {

            //Vector3 position = new Vector3(Random.Range(Minx, Maxx), Random.Range(Miny, Maxy),10);
			Vector3 position = new Vector3(Random.Range(panel.rect.xMin,panel.rect.xMax), Random.Range(panel.rect.yMin,panel.rect.yMax),10);
            pestlist[i]=Instantiate(pest, position, pest.transform.rotation);
            pestlist[i].transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
            i++;
           
        }

        
    }
	

	void Update () {
	if(timer.GetComponent<Timer>().timeLeft==0)
        {
            for(int x=0; x<pestlist.Length;x++)
            {
                Destroy(pestlist[x]);
            }
        }
    if (PlayerPrefs.GetInt("pestScore", 0) == 5 && isUpdatedScore == false)
    {
            PlayerPrefs.SetInt("gameSuccess", PlayerPrefs.GetInt("gameSuccess", 0) + 1);
            Debug.Log("Jumlah Kemenangan" + PlayerPrefs.GetInt("gameSuccess", 0));
            isUpdatedScore = true;
        }
    
}


    
}
