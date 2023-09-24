using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameController : MonoBehaviour
{
    public GameObject GameHolder;
    

    private void Awake()
    {
        CloseGame();
    }

    public void CloseGame()
    {
       GameHolder.SetActive(false);
    }

    public void OpenGame()
    {
        GameHolder.SetActive(true);
    }
}
