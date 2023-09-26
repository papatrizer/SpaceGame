using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleGun : Sound, IWeapon
{
    public GameObject bullet;
    public float cd;

    private float currentCd;
    private bool isFiring;
    private Vector3 deltaFire = new Vector3(0.05f, 0, 0);

    private void Update()
    {
        if (isFiring)
        {
            Fire();
        }
    }

    public void StartFire()
    {
        isFiring = true;
    }

    public void StopFire()
    {
        isFiring = false;
    }
    public void Fire()
    {
        if (currentCd <= 0)
        {
            Instantiate(bullet, transform.position - deltaFire, Quaternion.Euler(0, 0, 0));
            Instantiate(bullet, transform.position + deltaFire, Quaternion.Euler(0, 0, 0));
            PlaySound(sounds[0], 1);
            currentCd = cd;
        }
        else
        {
            currentCd -= Time.deltaTime;
        }
    }
}
