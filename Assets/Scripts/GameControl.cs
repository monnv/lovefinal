using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine;
using System.Linq;

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
        if (pictures.All(picture => picture.rotation.z == 0))
        {
            youWin = true;
            winText.SetActive(true);
        }
        
    }
}
