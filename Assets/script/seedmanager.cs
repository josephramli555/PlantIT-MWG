using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seedmanager : MonoBehaviour {


	public List<GameObject> ground;
	public List<GameObject> arrow;
    public int seedamount;
	public List <bool> answer;
    public GameObject buttonnext;
    public GameObject MinigameUI;

	public int rightAnswer;
	void Start () {
	
		answer= new List<bool>{false,false,false,false,false,false,false,false,false,};
		
		shuffleanswer();
		Invoke("hideanswer",3);
		rightAnswer=0;
			
	}
	
	// Update is called once per frame
	void Update () {
		Invoke("checkanswer",3);
        if (seedamount == 0)
        {
            buttonnext.SetActive(true);
            MinigameUI.SetActive(false);
			if(rightAnswer>=3)
			{
				PlayerPrefs.SetInt("gameSuccess",PlayerPrefs.GetInt("gameSuccess",0)+1);
			}
        }
	}


	void shuffleanswer()
	{
		int i=0;

		do
		{
			int x=Random.Range(1,9);
			if(answer[x]==false)
			{
			answer[x]=true;
			arrow[x].SetActive(true);
			i++;
            seedamount++;
			}
		}
		while(i<4);
	}		

	void hideanswer()
	{
		for(int i=0;i<9; i++)
		{
			arrow[i].SetActive(false);
			ground[i].GetComponent<Seeds>().index=i;
		}
	}

	void checkanswer()
	{
		// for(int i=0;i<9;i++)
		// {
		// 	if(answer[i]==true && ground[i].GetComponent<Seeds>().isselected==true)
		// 	{
		// 		Debug.Log("Jawaban benar");
		// 	}
		// 	else if(answer[i]==false && ground[i].GetComponent<Seeds>().isselected==true)
		// 	{
		// 		Debug.Log("Jawaban benar");
		// 	}
		// }
        // while(j>0){ seeds.onpointer() j-- }
	}
}
