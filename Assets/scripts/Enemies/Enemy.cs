using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Sound
{
    public int hp;
    public float speed;
    public float lifetime;
    private float currentTimer = 0;
    public int damage;
    private Player player;

    private void Awake()
    {
        player = FindObjectOfType<Player>();    
    }


    public void Update()
    {
        transform.Translate(Vector2.down * speed);
        if (hp <= 0)
        {
            GlobalEventManager.SendEnemyDeathHappens();
            Destroy(gameObject);
        }
        currentTimer += Time.deltaTime;
        if (currentTimer >= lifetime)
        {
            PlaySound(sounds[0], 1);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            player.TakeDamage(damage);
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
      hp -= damage;
    }
}
