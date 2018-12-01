using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fertilizermanager : MonoBehaviour
{


    public int clickedNumber;
    public List<GameObject> Item;
    public List<bool> answerFilled;

    public List<GameObject> Position;

    public GameObject questionUi;
    public GameObject answerUi;
    public GameObject timerUi;
    public GameObject swipeUi;
    public int rightAnswer;


    public Text Score;

    void Start()
    {
        PlayerPrefs.SetInt("gameSuccess",0);
        clickedNumber = 0;
        rightAnswer = 0;
        setindex();
        answerFilled = new List<bool> { false, false, false, false, false };
        shufflePosition();

        

    }

    // Update is called once per frame
    void Update()
    {
        if(timerUi.GetComponent<Timer>().timeLeft == 0)
        {
            questionUi.SetActive(false);
            timerUi.SetActive(false);
            answerUi.SetActive(true);
        }
        UpdateNilai();

    }



    void UpdateNilai()
    {
        Score.text = rightAnswer.ToString();
        if (clickedNumber == 3)
        {
            answerUi.SetActive(false);
            swipeUi.SetActive(true);
        }
    }
    void shufflePosition()
    {
        
        
        
        for(int positionarray=0;positionarray<5;positionarray++)
        {   
                GameObject obj = Position[positionarray];
                int randArr=Random.Range(0,positionarray);
                Position[positionarray]=Position[randArr];
                Position[randArr]=obj;
        }


        for(int i=0;i<5;i++)
        {
            Item[i].transform.position=Position[i].transform.position;

        }

        // int k = Random.Range(0, 10);

        // if (k <= 5)
        // {
        //     for (int y = 0; y < 5; y++)
        //     {
        //         int x = 4 - y;
        //         Vector3 pos = position[4 - y].transform.position;
        //         item[y].transform.position = pos;

        //     }
        // }
        // else
        // {
        //     for (int y = 0; y < 5; y++)
        //     {

        //         Vector3 pos = position[y].transform.position;
        //         item[y].transform.position = pos;

        //     }
        // }
    }


  



    void setindex()
    {
        for (int i = 0; i < 5; i++)
        {
            Item[i].GetComponent<item>().index = i;
        }
    }

    public void hidequestion()
    {
        questionUi.SetActive(false);
    }

    public void hideanswer(int k)
    {
        Item[k].SetActive(false);
    }
}
