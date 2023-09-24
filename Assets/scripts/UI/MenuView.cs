using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MenuView : MonoBehaviour, IMenuView
{
    public Text ScoreText; // toDo: вынести в отдельный класс  
   

    public event Action StartButtonClicked;
    public event Action SettingsButtonClicked;
    public event Action ScoreButtonClicked;

    public Button StartButton;
    public Button SettingsButton;
    public Button ScoreButton;


    public void ShowScore(int score)
    {
        ScoreText.text = score.ToString();
    }

    private void Awake()
    {
        StartButton.onClick.AddListener(handleStartButtonClick);
        SettingsButton.onClick.AddListener(handleSettingsButtonClick);
        ScoreButton.onClick.AddListener(handleScoreButtonClick);
    }

    void handleStartButtonClick()
    {
        StartButtonClicked();
    }

    void handleSettingsButtonClick()
    {
        SettingsButtonClicked();
    }

    void handleScoreButtonClick()
    {
        ScoreButtonClicked();
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }

    public void SetParent(Transform parent)
    {
        throw new NotImplementedException();
    }
}
