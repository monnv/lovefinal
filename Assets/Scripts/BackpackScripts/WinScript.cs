using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;
    public GameObject myItems;

    void Start()
    {
        pointsToWin = myItems.transform.childCount;
    }

   void Update()
    {
        if (currentPoints >= pointsToWin)
        {
            //Win
            transform.GetChild(0).gameObject.SetActive(true);
        }

    }

    public void AddPoints()
    {
        currentPoints++;
    }
}
