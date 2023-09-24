using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Menu : MonoBehaviour
{
    public MenuView menuView;
    public GameController gameController;
    public int score;


  //  public GameObject menu;
    private void Awake()
    {
       // Instantiate(menu, transform.position, Quaternion.Euler(0, 0, 0));
        Application.targetFrameRate = 60;
        menuView.StartButtonClicked += StartGame;
        menuView.SettingsButtonClicked += OpenSettings;
        menuView.ScoreButtonClicked += ShowTopScore;
        menuView.Show();
        GlobalEventManager.EnemyDeathHappens.AddListener(ChangeScore);
        GlobalEventManager.PlayerDeathHappens.AddListener(CloseGame);
    }

    private void ChangeScore()
    {
        menuView.ShowScore(++score);
    }

    private void StartGame()
    {
        menuView.Hide();
        gameController.OpenGame();
    }

    private void CloseGame()
    {
        menuView.Show();
        gameController.CloseGame();
    }

    private void OpenSettings()
    {

    }

    private void ShowTopScore()
    {

    }
}
