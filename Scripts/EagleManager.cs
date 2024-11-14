using UnityEngine;

public class EagleManager : MonoBehaviour
{
    public GameObject spawnObject;
    public GameObject[] spawnPoints;
    private float timer;
    public float timeBetweenSpawns;
    void Start()
    {

    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeBetweenSpawns)
        {
            timer = 0;
            int randNum = Random.Range(0, 5);
            Instantiate(spawnObject, spawnPoints[randNum].transform.position, Quaternion.identity);
        }
    }
}