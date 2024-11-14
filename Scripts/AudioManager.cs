using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header ("AudioSource")]
    [SerializeField] AudioSource musicSource;

    [Header("AudioClip")]
    public AudioClip backGround;

    public static AudioManager instance;
    public void Start()
    {
        musicSource.clip = backGround;
        musicSource.Play();
    }
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
