using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoobGun : MonoBehaviour, IWeapon
{
    public GameObject bullet;

    public float cd;
    private float currentCd;

    private void Update()
    {
        Fire();
    }

    public void Fire()
    {
        if (currentCd <= 0)
        {
            Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 0));
            currentCd = cd;
        }
        else
        {
            currentCd -= Time.deltaTime;
        }
    }
}
