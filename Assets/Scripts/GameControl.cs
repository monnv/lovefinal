using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private Transform[] pictures;

    [SerializeField]
    private GameObject winText;

    public static bool youWin;

    // Use this for initialization
    void Start()
    {
        winText.SetActive(false);
        youWin = false;
    }

    //Update is called once per frame
    void Update()
    {
        if (pictures[1].rotation.z == 00 &&
          pictures[2].rotation.z == 00 &&
          pictures[3].rotation.z == 00 &&
          pictures[4].rotation.z == 00 &&
          pictures[5].rotation.z == 00 &&
          pictures[6].rotation.z == 00 &&
          pictures[7].rotation.z == 00 &&
          pictures[8].rotation.z == 00 &&
          pictures[9].rotation.z == 00 &&
          pictures[10].rotation.z == 00 &&
          pictures[11].rotation.z == 00 &&
          pictures[12].rotation.z == 00 &&
          pictures[13].rotation.z == 00 &&
          pictures[14].rotation.z == 00 &&
          pictures[15].rotation.z == 00 &&
          pictures[16].rotation.z == 00)
        {
            youWin = true;
            winText.SetActive(true);
        }
        
    }
}
