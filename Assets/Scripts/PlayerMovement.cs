using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;

    public float minX = -5.0f;
    public float maxX = 5.0f;
    public float minZ = -5.0f;
    public float maxZ = 5.0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float MovAdelanteAtras = Input.GetAxis("Vertical") * speed;
        float MovIzqDer = Input.GetAxis("Horizontal") * speed;

        MovAdelanteAtras *= Time.deltaTime;
        MovIzqDer *= Time.deltaTime;

        Vector3 newPosition = transform.position + new Vector3(MovIzqDer, 0, MovAdelanteAtras);

        // Limita la nueva posición dentro de los límites definidos
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        newPosition.z = Mathf.Clamp(newPosition.z, minZ, maxZ);

        //transform.Translate(MovIzqDer, 0, MovAdelanteAtras);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
