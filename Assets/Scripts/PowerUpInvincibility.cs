using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpInvincibility : MonoBehaviour
{

    public Animator PlayerAnimator;
    public float triggerDuration = 5f;

    private Collider playerCollider;
    private bool isCoroutineRunning = false;

    private void Start()
    {

        playerCollider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("Player") && !isCoroutineRunning)
        {
            StartCoroutine(ActivateTriggerCollider());
            Destroy(gameObject);
        }
    }

    private IEnumerator ActivateTriggerCollider()
    {
        isCoroutineRunning = true;

        PlayerAnimator.SetBool("IsActivated", true);

        // Cambiar el collider del jugador a trigger
        playerCollider.isTrigger = true;

        yield return new WaitForSeconds(triggerDuration);

        // Restaurar el collider del jugador a su estado original (no trigger)
        playerCollider.isTrigger = false;

        isCoroutineRunning = false;

        PlayerAnimator.SetBool("IsActivated", false);
    }

}




