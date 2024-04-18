using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;

    public GameObject explosionPowerUp;
    private Animator PlayerAnimator;


    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float MovAdelanteAtras = Input.GetAxis("Vertical") * speed;
        float MovIzqDer = Input.GetAxis("Horizontal") * speed;

        MovAdelanteAtras *= Time.deltaTime;
        MovIzqDer *= Time.deltaTime;


        transform.Translate(MovIzqDer, 0, MovAdelanteAtras);

        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    Cursor.lockState = CursorLockMode.None;
        //}
    }

   
}



