using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameController : MonoBehaviour
{
    public GameObject GameHolder;
    public Player Player;
    public BuffController BuffController;
    

    private void Awake()
    {
        CloseGame();
        GlobalEventManager.BuffStarted.AddListener(ActivateBuff);
        GlobalEventManager.BuffFinished.AddListener(DeActivateBuff);
    }

    public void CloseGame()
    {
       GameHolder.SetActive(false);
    }

    public void OpenGame()
    {
        GameHolder.SetActive(true);
    }

    public void ActivateBuff(IBuff buff)
    {
        switch (buff.BuffType)
        {
            case EBuff.TrippleGunBuff:
                Player.ChangeWeapon(EWeapon.TrippleGun);
                break;
            case EBuff.DoubleGunBuff:
                Player.ChangeWeapon(EWeapon.DoubleGun);
                break;
            case EBuff.HealBuff:
                Player.hp += 20;
                break;
        }
                
    
    }

    public void DeActivateBuff(IBuff buff)
    {
        switch (buff.BuffType)
        {
            case EBuff.TrippleGunBuff:
                Player.ChangeWeapon(EWeapon.NoobGun);
                break;
            case EBuff.DoubleGunBuff:
                Player.ChangeWeapon(EWeapon.NoobGun);
                break;
            case EBuff.HealBuff:
                break;
        }
        Player.ChangeWeapon(EWeapon.NoobGun);
    }
}
