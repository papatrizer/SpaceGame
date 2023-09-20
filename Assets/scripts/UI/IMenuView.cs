using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IMenuView
{
    event Action StartButtonClicked;
    event Action SettingsButtonClicked;
    event Action ScoreButtonClicked;

    void SetParent(Transform parent);

    void Show();
    void Hide();
}
