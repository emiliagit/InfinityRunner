using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerUps : MonoBehaviour
{

    public GameObject powerUpPrefab;
    //public float SpawnInterval = 10f;


    private float MinX = -4f;
    private float maxX = 4f;

    private float minTime = 10f;
    private float maxTime = 20f;

    public float delay;


    // Start is called before the first frame update
    void Start()
    {
        //delay = 10f;
        StartCoroutine(spawnPowerUp());
    }


    private IEnumerator spawnPowerUp()
    {
        while (true)
        {
            delay = 10f;

            float randomTime = Random.Range(minTime, maxTime);

            
                Vector3 spawnPosition = transform.position;
                spawnPosition.x = Random.Range(MinX, maxX);
                Instantiate(powerUpPrefab, spawnPosition, Quaternion.identity);
            
           
                //Instantiate(powerUpPrefab[randomindex], transform.position, Quaternion.identity);
       
            yield return new WaitForSeconds(randomTime);
        }
    }

   
}
