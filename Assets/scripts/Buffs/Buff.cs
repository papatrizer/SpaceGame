using UnityEngine;

public class Buff : Sound, IBuff
{
    public float speed;
    public float lifetime;

    private float currentTimer = 0;
    private int duration = 5;
   [SerializeField] private EBuff buffType = EBuff.TrippleGunBuff;


    public int Duration { get { return duration; } set { duration = value; } }
    public EBuff BuffType { get { return buffType; } }

    void Update()
    {
        transform.Translate(Vector2.down * speed);
     
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
            GlobalEventManager.SendBuffTouched(this);
            Destroy(gameObject);
        }
    }
}
