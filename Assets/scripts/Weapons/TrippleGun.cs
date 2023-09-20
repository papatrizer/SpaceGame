using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrippleGun : MonoBehaviour
{
    public GameObject bullet;

    public float cd;
    private float currentCd;
    private bool isFiring = true;

    private void Update()
    {
        if (isFiring)
        {
           Fire();
        }
    }

    public void Fire()
    {
        if (currentCd <= 0)
        {
            Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 0));
            Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 25f));
            Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, -25f));
            currentCd = cd;
        }
        else
        {
            currentCd -= Time.deltaTime;
        }
    }
}
