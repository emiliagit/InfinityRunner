using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScroll : MonoBehaviour
{

    public float ScrollSpeed = 8.0f;
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
