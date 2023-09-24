using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TrippleGunBuff : Sound
{
    public float speed;
    public float lifetime;

    private float currentTimer = 0;
    private Player player;


    private void Awake()
    {
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        transform.Translate(Vector2.down * speed);
     
        currentTimer += Time.deltaTime;
        if (currentTimer >= lifetime)
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator WaitForBuffDuration()
    {
        player.ChangeWeapon(EWeapon.TrippleGun);
        yield return new WaitForSeconds(3);
        player.ChangeWeapon(EWeapon.NoobGun);
        Destroy(gameObject);
       
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            StartCoroutine(WaitForBuffDuration());
            PlaySound(sounds[0], 1);
            this.gameObject.GetComponent<CircleCollider2D>().enabled = false;
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
