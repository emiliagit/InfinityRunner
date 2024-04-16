using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGround : MonoBehaviour
{

    public GameObject objectToSpawn;
    public float spawnInterval = 2f;
    public float objectLifetime = 5f;
    private float timer = 0f;

    private void Update()
    {

        timer += Time.deltaTime;


        if (timer >= spawnInterval)
        {
            SpawnObject();
            timer = 0f;
        }
    }


    private void SpawnObject()
    {
        GameObject newObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        newObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        Destroy(newObject, objectLifetime);
    }
}
