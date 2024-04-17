using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGround : MonoBehaviour
{

    public float offsetZ = 22f;
    public float ScrollSpeed = 6.0f;  // Velocidad inicial de desplazamiento
    public float accelerationRate = 0.5f;    // Tasa de aceleraci�n
    private float timeElapsed = 0f;
    public float resetZ = 0f;// Tiempo transcurrido desde el inicio

    void Update()
    {
        // Aumenta el tiempo transcurrido
        timeElapsed += Time.deltaTime;

        // Calcula la velocidad de desplazamiento en funci�n del tiempo transcurrido
        float currentScrollSpeed = ScrollSpeed + accelerationRate * timeElapsed;

        // Mueve el objeto con la velocidad calculada
        transform.position -= new Vector3(0, 0, currentScrollSpeed * Time.deltaTime);

        if (transform.position.z <= offsetZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, resetZ);
        }
    }
}
