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
    public GameObject swipeUi;
    public int rightAnswer;


    public Text Score;
    void Start()
    {
        clickedNumber = 0;
        rightAnswer = 0;
        setindex();
        answerFilled = new List<bool> { false, false, false, false, false };
        shufflePosition(Item, Position);

        

    }

    // Update is called once per frame
    void Update()
    {
        UpdateNilai();

    }



    void UpdateNilai()
    {
        Score.text = rightAnswer.ToString();
        if (clickedNumber == 3)
        {
            questionUi.SetActive(false);
            swipeUi.SetActive(true);
        }
    }
    void shufflePosition(List<GameObject> item, List<GameObject> position)
    {

        int k = Random.Range(0, 10);

        if (k <= 5)
        {
            for (int y = 0; y < 5; y++)
            {
                int x = 4 - y;
                Vector3 pos = position[4 - y].transform.position;
                item[y].transform.position = pos;

            }
        }
        else
        {
            for (int y = 0; y < 5; y++)
            {

                Vector3 pos = position[y].transform.position;
                item[y].transform.position = pos;

            }
        }
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
