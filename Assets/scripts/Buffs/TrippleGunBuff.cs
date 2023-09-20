using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrippleGunBuff : MonoBehaviour
{
    public float speed;
    public float lifetime;
    private float currentTimer = 0;
    public float duration;
    private float currentDuration = 0;

    public GameObject player;


    private void Awake()
    {
        player = GameObject.Find("player");
    }

    void Update()
    {
        var noobGun = player.GetComponent<NoobGun>();
        var trippleGun = player.GetComponent<TrippleGun>();
        if(trippleGun.enabled)
        {
            currentDuration += Time.deltaTime;
            if(currentDuration >= duration)
            {
                trippleGun.enabled = false;
                noobGun.enabled = true;
                currentDuration = 0;
            }
        }

        transform.Translate(Vector2.down * speed);
     
        currentTimer += Time.deltaTime;
        if (currentTimer >= lifetime)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        var noobGun = player.GetComponent<NoobGun>();
        var trippleGun = player.GetComponent<TrippleGun>();
        if (other.gameObject.CompareTag("player"))
        {
            noobGun.enabled = false;
            trippleGun.enabled = true;
            Destroy(gameObject);
        }
    }
}
