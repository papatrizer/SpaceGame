using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using System;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public int hp;

    public Text text; // toDo: вынести в отдельный класс  
    public static int score;

    public static event Action deathHappens;

    private void Awake()
    {
        
    }

    private void Update()
    {
        if(IsDead())
        {
            Death();
        }
        text.text = score.ToString();
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
    }

    private bool IsDead()
    { 
        return hp <= 0;
    }
    private void Death()
    {
        deathHappens();
    }

}
  
