using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    private float groundWidth;
    private float groundSpeed = 0.001f;
    public float accelerationRate = 0.5f;
    private float TimeElapsed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider groundCollider = GetComponent<BoxCollider>();
        groundWidth = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < groundWidth)
        {

            TimeElapsed += Time.deltaTime;

            float currentScrollSpeed = groundSpeed + accelerationRate * TimeElapsed;

            transform.Translate(Vector3.right * groundSpeed * groundWidth);
        }
    }
}
