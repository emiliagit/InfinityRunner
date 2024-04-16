using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public Animator playerAnimator;
    //public float animationDuration = 2f;
    //public GameManager gameManager; 

    private bool isCollisionHandled = false;
    public float delay = 2f;

    private LifePlayer lifePlayer;

    private void Start()
    {
        lifePlayer = GetComponent<LifePlayer>();
    }
    private void OnCollisionEnter(Collision collision)
    {
       
        if (!isCollisionHandled && collision.collider.CompareTag("Player"))
        {
            StartCoroutine(damagePlayer());
           
            //playerAnimator.SetBool("Hit", true);

            Destroy(gameObject);

            //lifePlayer.RecibirDanio(1);



            //isCollisionHandled = true;
            //gameManager.DecreaseLife();
        }
    }
    IEnumerator damagePlayer() 
    {

        isCollisionHandled = true;

        playerAnimator.SetBool("Hit", true);

        lifePlayer.RecibirDanio(1);

        yield return new WaitForSeconds(delay);

        playerAnimator.SetBool("Hit", false);

    }


}
