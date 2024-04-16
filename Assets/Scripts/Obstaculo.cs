using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public GameObject powerUpPrefab;
    public float powerUpDuration = 2f; 
    private bool hasCollided = false;

    private LifePlayer player;

    private void OnCollisionEnter(Collision collision)
    {
        if (!hasCollided && collision.gameObject.CompareTag("Player"))
        {
            // Instanciar el prefab de la animaci�n del power-up
            Instantiate(powerUpPrefab, transform.position, Quaternion.identity);

            player.TakeDamage(1);

            // Eliminar el objeto que colision� (el power-up)
            Destroy(gameObject);


            hasCollided = true;
        }
    }
}

   
