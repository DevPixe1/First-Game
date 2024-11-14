using UnityEngine;

public class Rock : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float lifeTime;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        rb.velocity = Vector2.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Eagle"))
        {
            Destroy(gameObject);
        }
    }
}
