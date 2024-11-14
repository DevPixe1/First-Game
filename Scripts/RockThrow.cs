using UnityEngine;
using UnityEngine.UI;

public class RockThrow : MonoBehaviour
{
    public GameObject spawnObject;
    public GameObject[] spawnPoints;

    public Slider RockCharge;

    float nextAttackTime = 0;

    public Animator animatior;
    
    public void Throw()
    {
        if (Time.time >= nextAttackTime)
        {
            nextAttackTime = Time.time + 2f;
            Instantiate(spawnObject, spawnPoints[0].transform.position, Quaternion.identity);
            animatior.SetTrigger("Charge");
        }
    }
}
