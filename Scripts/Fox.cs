using UnityEngine;
using UnityEngine.SceneManagement;

public class Fox : MonoBehaviour
{
    public float jumpForce;
    private Rigidbody2D rb;
    private bool isGrounded;
    public GameObject pauseButton;
    public GameObject jumpButton;
    public GameObject attackButton;
    public GameObject resetButton;
    public static bool GameIsPaused = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Jump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }
    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Eagle"))
        {
            Time.timeScale = 0f;
            GameIsPaused = true;
            resetButton.SetActive(true);


        }
    }
}
