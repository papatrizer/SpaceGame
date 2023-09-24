using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public int damage;
    private float currentTimer = 0;

    
     


    private void Update()
    {
        transform.Translate(Vector2.up * speed);
        currentTimer += Time.deltaTime;
        if (currentTimer >= lifetime)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<Enemy>().TakeDamage(damage);
            Destroy(gameObject);          
        }
    }
    

}
