using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{

    private float groundWidth;
    public float groundSpeed = 0.5f;
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
            transform.Translate(Vector3.right * groundSpeed * groundWidth);
        }
    }
}
