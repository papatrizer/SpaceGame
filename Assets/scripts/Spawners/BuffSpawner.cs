using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffSpawner : MonoBehaviour
{
    public GameObject buff;

    public float cd;
    private float currentCd;
    private float minX = -2;
    private float maxX = 2.5f;

    void Update()
    {
        Spawner();
    }
    public void Spawner()
    {
        if (currentCd <= 0)
        {
            Instantiate(buff, new Vector3(Random.Range(minX, maxX), 6), Quaternion.Euler(0, 0, 0));
            currentCd = cd;
        }
        else
        {
            currentCd -= Time.deltaTime;
        }
    }
}
