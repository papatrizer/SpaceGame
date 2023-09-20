using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Menu : MonoBehaviour
{
    public MenuView menuView;
    public GameController gameController;

  //  public GameObject menu;
    private void Awake()
    {
       // Instantiate(menu, transform.position, Quaternion.Euler(0, 0, 0));
        Application.targetFrameRate = 60;
        menuView.StartButtonClicked += StartGame;
        menuView.SettingsButtonClicked += OpenSettings;
        menuView.ScoreButtonClicked += ShowTopScore;
        menuView.Show();
    }

    private void StartGame()
    {
        menuView.Hide();
        gameController.OpenGame();
    }

    private void OpenSettings()
    {

    }

    private void ShowTopScore()
    {

    }
}
