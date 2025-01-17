using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class specialObstacle : MonoBehaviour
{
    public float velocidad = 4f; // Velocidad de movimiento
    public float limiteIzquierdo = -4f; // L�mite izquierdo
    public float limiteDerecho = 4f; // L�mite derecho
    private bool moviendoDerecha = true; // Direcci�n inicial

    void Update()
    {
        // Mueve el objeto hacia la derecha o la izquierda seg�n la direcci�n actual
        if (moviendoDerecha)
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }

        // Si alcanza uno de los l�mites, cambia la direcci�n
        if (transform.position.x >= limiteDerecho)
        {
            moviendoDerecha = false;
        }
        else if (transform.position.x <= limiteIzquierdo)
        {
            moviendoDerecha = true;
        }
    }
    
}
