using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour {

    public List<GameObject> hidObj;
    public List<GameObject> pages;
    public int pageTotal;
    public int currPage;
    public GameObject game;
    public GameObject mainPage;
    void Start()
    {
        currPage = 0;
        pageTotal = pages.Count;
        pages[0].SetActive(true);
    }

    public void NextPage()
    {
        if (pageTotal == 1)
        {
            pages[currPage].SetActive(false);
            mainPage.SetActive(false);
            game.SetActive(true);
        }
        else
        {

            if (currPage == 0)
            {
                pages[0].SetActive(false);
                pages[1].SetActive(true);
                currPage++;
            }

            else if (currPage < pageTotal - 1)
            {
                pages[currPage].SetActive(false);
                pages[currPage + 1].SetActive(true);
                currPage++;
            }
            else if (currPage == pageTotal - 1)
            {
                pages[currPage].SetActive(false);
                mainPage.SetActive(false);
                game.SetActive(true);
            }

        }

    }

    



}
