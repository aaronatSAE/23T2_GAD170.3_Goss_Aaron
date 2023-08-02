using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactTester : MonoBehaviour
{
    // We want this script to handle COLLISION and TRIGGER detection!
    // When our object impacts another, we want to PRINT TEXT.

    // First, collisions...

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ouch! I have collided with something!");

        // Play a sound effect
        // Show a particle effect
        // Change the colour of this object
        // Destroy one of the two objects in this collision

        // Destroy the GROUND
        Destroy(collision.gameObject);
    }

    // Next, triggers...

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ouch! I have triggered something!");
    }
}
