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
    public GameObject bullet;
    public List<GameObject> guns;
    


    private IWeapon currentWeapon;
    private Dictionary<EWeapon, IWeapon> weapons = new Dictionary<EWeapon, IWeapon>();
    

    private void Awake()
    {       
        weapons.Add(EWeapon.NoobGun, guns[0].GetComponent<IWeapon>());
        weapons.Add(EWeapon.TrippleGun, guns[1].GetComponent<IWeapon>());
        ChangeWeapon(EWeapon.NoobGun);
    }

    public void ChangeWeapon(EWeapon weapon)
    {
        foreach (var w in weapons.Values)
            w.StopFire();
        currentWeapon = weapons[weapon];
        currentWeapon.StartFire();
    }

    private void Update()
    {

    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            GlobalEventManager.SendPlayerDeathHappens();
        }
    }
}
  
