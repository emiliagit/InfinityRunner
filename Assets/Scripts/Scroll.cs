using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{

    //si le pongo un asset de un mundo que se tenga que mover a la velocidad de los enemigos no voy anecesitar poner que el piso se mueva. Evaluar

    public float ScrollSpeed = 6.0f;
    public float accelerationRate = 0.5f;
    private float TimeElapsed = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeElapsed += Time.deltaTime;

        float currentScrollSpeed = ScrollSpeed + accelerationRate * TimeElapsed;

        transform.Translate(Vector3.back * currentScrollSpeed * Time.deltaTime);
    }
}
