using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    private int pointsToWin;
    public static int currentPoints;
    public GameObject BPObjects;

    void Start()
    {
        pointsToWin = BPObjects.transform.childCount;
    }

   void Update()
    {
        if (currentPoints == pointsToWin)
        {
            //Win
            transform.GetChild(0).gameObject.SetActive(true);
        }

    }

}
