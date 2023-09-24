using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class GlobalEventManager : MonoBehaviour
{
    public static UnityEvent PlayerDeathHappens = new UnityEvent();
    public static UnityEvent EnemyDeathHappens = new UnityEvent();



    public static void SendPlayerDeathHappens()
    {
        PlayerDeathHappens.Invoke();
    }

    public static void SendEnemyDeathHappens()
    {
        EnemyDeathHappens.Invoke();
    }
}
