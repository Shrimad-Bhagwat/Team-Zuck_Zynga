using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour
{
    [SerializeField]
    GameObject asteroid;
    [SerializeField]
    float _screenBoundX = 12.8f;
    [SerializeField]
    float _screenBoundZ = -11.5f;
    [SerializeField]
    float waitTime = 1f;

    private void spawnEnemy()
    {
        GameObject g = Instantiate(asteroid) as GameObject;
        g.transform.position = new Vector3(Random.Range(_screenBoundX, -_screenBoundX), 0, _screenBoundZ * 1.4f);
    }
    IEnumerator wave()
    {
        while(true)
        {
            yield return new WaitForSeconds(waitTime);
            spawnEnemy();

        }
    }
    void Start()
    {
        StartCoroutine(wave());
    }

 
}
