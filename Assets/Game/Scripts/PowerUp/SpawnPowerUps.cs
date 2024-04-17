using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerUps : MonoBehaviour
{

    public GameObject[] powerUpPrefab;
    public float SpawnInterval = 10f;


    public float MinX = -1.0f;
    public float maxX = 1.0f;

    private float minTime = 1f;
    private float maxTime = 2f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnPowerUp());
    }


    private IEnumerator spawnPowerUp()
    {
        while (true)
        {
            int randomindex = Random.Range(0, powerUpPrefab.Length);
           
            float randomTime = Random.Range(minTime, maxTime);

            if (randomindex == powerUpPrefab.Length - 1)
            {
                Vector3 spawnPosition = transform.position;
                spawnPosition.x = Random.Range(MinX, maxX) * powerUpPrefab[randomindex].transform.localScale.x;
                Instantiate(powerUpPrefab[randomindex], spawnPosition, Quaternion.identity);
            }
            else
            {
                Instantiate(powerUpPrefab[randomindex], transform.position, Quaternion.identity);
            }
            yield return new WaitForSeconds(randomTime);
        }
    }

   
}
