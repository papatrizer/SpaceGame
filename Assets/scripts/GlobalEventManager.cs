using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class GlobalEventManager : MonoBehaviour
{
    public static UnityEvent PlayerDeathHappens = new UnityEvent();
    public static UnityEvent EnemyDeathHappens = new UnityEvent();
    public static UnityEvent<IBuff> BuffTouched = new UnityEvent<IBuff>();
    public static UnityEvent<IBuff> BuffStarted = new UnityEvent<IBuff>();
    public static UnityEvent<IBuff> BuffFinished = new UnityEvent<IBuff>();



    public static void SendPlayerDeathHappens()
    {
        PlayerDeathHappens.Invoke();
    }

    public static void SendEnemyDeathHappens()
    {
        EnemyDeathHappens.Invoke();
    }

    public static void SendBuffTouched(IBuff buff)
    {
        BuffTouched.Invoke(buff);
    }

    public static void SendBuffStarted(IBuff buff)
    {
        BuffStarted.Invoke(buff);
    }

    public static void SendBuffFinished(IBuff buff)
    {
        BuffFinished.Invoke(buff);
    }
}
