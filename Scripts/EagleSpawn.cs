using UnityEngine;

public class EagleSpawn : MonoBehaviour
{
    private Rigidbody2D rb;
    public float startingSpeed;
    private float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        speed = startingSpeed;
    }

    void Update()
    {
        speed = GameManager.Instance.gameSpeed;
        rb.velocity = Vector2.left * speed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Rock"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("Object Destroyer"))
        {
            Destroy(gameObject);
        }
    }
}
