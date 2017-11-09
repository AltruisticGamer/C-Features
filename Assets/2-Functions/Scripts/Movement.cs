using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movement : MonoBehaviour
{
    public float movementSpeed = 20f;
    public float rotationSpeed = 20f;

    // Use this for input and Updates
    void Update()
    {
        // check if user presses W
        if (Input.GetKey(KeyCode.W))
        {
            // Move up
            transform.Translate(new Vector3(0, movementSpeed, 0) * Time.deltaTime);
        }
        // check if user presses S
        if (Input.GetKey(KeyCode.S))
        {
            // Move down
            transform.Translate(new Vector3(0, -movementSpeed, 0) * Time.deltaTime);
        }
        // check if user presses D
        if (Input.GetKey(KeyCode.D))
        {
            // Move Right
            transform.Translate(new Vector3(movementSpeed, 0, 0) * Time.deltaTime);
        }
        // check if user presses A
        if (Input.GetKey(KeyCode.A))
        {
            // Move Right
            transform.Translate(new Vector3(-movementSpeed, 0, 0) * Time.deltaTime);
        }
    }

    // Play at Start
    void Start()
    {
        print("PROGRAMMING IS FUN");

    }
}
