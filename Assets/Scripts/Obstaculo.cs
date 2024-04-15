using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public Animator playerAnimator; 
    public float animationDuration = 2f; 
    //public GameManager gameManager; 
    private bool isCollisionHandled = false; 

    private void OnCollisionEnter(Collision collision)
    {
       
        if (!isCollisionHandled && collision.collider.CompareTag("Player"))
        {
           
             playerAnimator.SetBool("IsDamaged", true);
         
            //if (gameManager != null)
            //{
            //    gameManager.DecreaseLife();
            //}

            StartCoroutine(StopAnimationAfterDelay());

            isCollisionHandled = true;
        }
    }

    private IEnumerator StopAnimationAfterDelay()
    {
        yield return new WaitForSeconds(animationDuration);

        playerAnimator.SetBool("IsDamaged", false);
      
        isCollisionHandled = false;
    }
}
