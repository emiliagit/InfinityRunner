using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour
{
    public GameObject explosionPrefab;

    private LifePlayer player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            // Instanciar el prefab de la animación del power-up
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            Debug.Log("daño");
            Destroy(explosionPrefab, 1f);

            player.TakeDamage(1);

            // Eliminar el objeto que colisionó 
            Destroy(collision.gameObject);

        }
    }
}
