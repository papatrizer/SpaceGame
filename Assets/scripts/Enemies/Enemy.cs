using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp;
    public float speed;
    public float lifetime;
    private float currentTimer = 0;
    public int damage;


   

    public void Update()
    {
        transform.Translate(Vector2.down * speed);
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
        currentTimer += Time.deltaTime;
        if (currentTimer >= lifetime)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            other.gameObject.GetComponent<Player>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
      hp -= damage;
    }
}
