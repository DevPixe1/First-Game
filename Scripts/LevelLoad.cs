using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    public Slider progressBar;

    public void Load(int level)
    {
        StartCoroutine(startLoading (level));
    }
    IEnumerator startLoading(int level)
    {
        AsyncOperation async = SceneManager.LoadSceneAsync (level);

        while (!async.isDone)
        {
            progressBar.value = async.progress;
            yield return null;
        }
    }
}
