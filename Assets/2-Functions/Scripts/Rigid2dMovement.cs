using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Functions
{

    public class Rigid2dMovement : MonoBehaviour
    {
        public float dashSpeed = 50f;
        public float rotationSpeed = 5f;
        public float acceleration = 20f;
        public float deceleration = 0.1f;

        private Rigidbody2D rigid2D;

        // Use this for initialization
        void Start()
        {
            // Get rigidbody component
            rigid2D = GetComponent<Rigidbody2D>();
        }
        // Above Update

        // Update is called once per frame
        void Update()
        {
            //If we press the spacebar
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Make the player Dash
                Dash();
            }
            // Calling a Function
            Accelerate();
            Decelerate();
            Rotate();
        }
        // Under Update
        void Accelerate()
        {
            // Get Input from vertical axes
            float inputV = Input.GetAxis("Vertical");
            // Add force to the right direction of the Player
            rigid2D.AddForce(transform.up * inputV * acceleration);
        }
        void Decelerate()
        {
            // velocity += velocity * deceleration
            rigid2D.velocity += -rigid2D.velocity * deceleration;
        }
        void Dash()
        {
            rigid2D.AddForce(transform.up * dashSpeed, ForceMode2D.Impulse);        
        }
        void Rotate()
        {
            // Get Horizontal Input
            float inputH = Input.GetAxis("Horizontal");
            // Perform rotation Input
            transform.Rotate(Vector3.forward, rotationSpeed * -inputH);
        }

    }
}
