using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public GameObject spawner;
    private void Awake()
    {
        CloseGame();
        Player.deathHappens += CloseGame;
    }

    public void CloseGame()
    {
        player.SetActive(false);
        spawner.SetActive(false);
    }

    public void OpenGame()
    {
        player.SetActive(true);
        spawner.SetActive(true);
    }
}
