using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject[] obstaculos;
    public float MinX = -1.0f;
    public float maxX = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnobstacle());
    }


    private IEnumerator spawnobstacle()
    {
        while (true)
        {
            int randomindex = Random.Range(0, obstaculos.Length);
            float minTime = 0.6f;
            float maxTime = 1.8f;
            float randomTime = Random.Range(minTime, maxTime);

            if(randomindex == obstaculos.Length - 1)
            {
                Vector3 spawnPosition = transform.position;
                spawnPosition.x = Random.Range(MinX, maxX) * obstaculos[randomindex].transform.localScale.x;
                Instantiate(obstaculos[randomindex], spawnPosition, Quaternion.identity);
            }
            else
            {
                Instantiate(obstaculos[randomindex], transform.position, Quaternion.identity);
            }
            yield return new WaitForSeconds(randomTime);
        }
    }
   
}
