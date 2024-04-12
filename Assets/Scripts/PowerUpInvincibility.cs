using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpInvincibility : MonoBehaviour
{

    public float invincibilityDuration = 5f;

    public Animator playerAnimator;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(GrantInvincibility(collision.collider));
            gameObject.SetActive(false); //desactivar power up despues de ser recolectado

        }
    }

    private IEnumerator GrantInvincibility(Collider playerCollider)
    {

        // Obtener todos los colliders con la etiqueta "Obstaculos"
        GameObject[] obstacleObjects = GameObject.FindGameObjectsWithTag("Obstaculo");
        Collider[] obstacles = new Collider[obstacleObjects.Length];

        // Obtener los colliders de los objetos encontrados
        for (int i = 0; i < obstacleObjects.Length; i++)
        {
            obstacles[i] = obstacleObjects[i].GetComponent<Collider>();
        }

        foreach (Collider obstacle in obstacles)
        {
            Physics.IgnoreCollision(playerCollider, obstacle, true);
        }

        Debug.Log("corrutina activada con exito");

        yield return new WaitForSeconds(invincibilityDuration);

        foreach (Collider obstacle in obstacles)
        {
            Physics.IgnoreCollision(playerCollider, obstacle, false);
        }

        
        if (playerAnimator != null)
        {
            playerAnimator.SetTrigger("PowerUpCollected"); // Nombre del trigger para la animación
        }

        Debug.Log("Animacion activada");

        if (playerAnimator != null)
        {
            playerAnimator.SetTrigger("PowerUpEnd"); // Nombre del trigger para la animación
        }
    }

    
}
