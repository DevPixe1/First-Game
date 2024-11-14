using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstLoad : MonoBehaviour
{
    public float delay;
    void Start()
    {
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(1);
    }
}
