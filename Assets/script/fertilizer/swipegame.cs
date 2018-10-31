using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class swipegame : MonoBehaviour
{

    // Use this for initialization

    public GameObject manager;
    public List<GameObject> arrow;

    public enum directionSwipe
    {

        Left = 0,
        Right = 1,
        Up = 2,
        Down = 3,
    }

    directionSwipe direction;
    directionSwipe directionsebelumnya;
    public int jumlahLevel;
    int totalSwipe;

    public GameObject nextLevel;
    public int score;

    public bool isUpdatedScore;
    public Text ScoreResult;

    public bool endGame;
    void Start()
    {
        endGame=false;
        isUpdatedScore=false;
        totalSwipe = 0;
        randomDirection();
        score = manager.GetComponent<fertilizermanager>().rightAnswer;
        directionsebelumnya = directionSwipe.Left;

    }


    void Update()
    {
        checkDirection();
        UpdateNilai();
    }

    void randomDirection()
    {
        int i;

        do
        {
            i = Random.Range(0, 3);
            direction = (directionSwipe)i;
        } while (directionsebelumnya == direction);

        directionsebelumnya = direction;

        int reset = 0;

        do
        {
            arrow[reset].SetActive(false);//matikan semua arrow object
            reset++;
        }
        while (reset < 4);
        arrow[i].SetActive(true);//nyalain yang bener

    }

    void UpdateNilai()
    {
        ScoreResult.text = score.ToString();
        if (totalSwipe == 5)
        {
            endGame=true;
            if(isUpdatedScore==false)
            {
                PlayerPrefs.SetInt("gameSuccess",PlayerPrefs.GetInt("gameSuccess",0)+1);
                isUpdatedScore=true;
                Debug.Log("Jumlah Kemenangan"+PlayerPrefs.GetInt("gameSuccess",0));
            }
            nextLevel.SetActive(true);
        }
    }
    void checkDirection()
    {
        if(endGame==false)
        {
        if (direction == directionSwipe.Left && swipemanager.Instance.IsSwiping(swipeDirection.Left))
        {
            Debug.Log("benar");
            randomDirection();
            totalSwipe++;
            score++;
        }
        else if (direction == directionSwipe.Right && swipemanager.Instance.IsSwiping(swipeDirection.Right))
        {
            Debug.Log("benar");
            randomDirection();
            totalSwipe++;
            score++;
        }
        else if (direction == directionSwipe.Up && swipemanager.Instance.IsSwiping(swipeDirection.Up))
        {
            Debug.Log("benar");
            randomDirection();
            totalSwipe++;
            score++;
        }
        else if (direction == directionSwipe.Down && swipemanager.Instance.IsSwiping(swipeDirection.Down))
        {
            Debug.Log("benar");
            randomDirection();
            totalSwipe++;
            score++;
        }
        else if (swipemanager.Instance.IsSwiping(swipeDirection.Down) || swipemanager.Instance.IsSwiping(swipeDirection.Up)
                || swipemanager.Instance.IsSwiping(swipeDirection.Left) || swipemanager.Instance.IsSwiping(swipeDirection.Right))
        {
            randomDirection();
            totalSwipe++;
        }

    }
    }
}
