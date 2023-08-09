using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DangerButton : MonoBehaviour
{
    // When the player character enters this zone,
    // allow them to press the button!

    [SerializeField] private TextMeshPro buttonWarningText;
    [SerializeField] private bool isPlayerCharacterNextToButton = false;

    [SerializeField] private GameObject fallingJellyPrefab;
    [SerializeField] private Transform spawnPoint;

    private void Update()
    {
        // When the player presses E to activate the button...
        if (Input.GetKeyDown(KeyCode.E) && isPlayerCharacterNextToButton)
        {
            // ...spawn a falling jelly cube above them!
            Debug.Log("DANGER ZONE ACTIVATED");

            GameObject newJelly = Instantiate(fallingJellyPrefab, spawnPoint.position, Random.rotation);

            newJelly.GetComponent<Rigidbody>().AddForce(Vector3.up * 800f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER has been TRIGGERED!");

        // if the player character triggers this method...
        if (other.CompareTag("Player"))
        {
            // ...show things!
            buttonWarningText.enabled = true;
            isPlayerCharacterNextToButton = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("TRIGGER has been LEFT ALL ALONE!");

        // if the player character triggers this method...
        if (other.CompareTag("Player"))
        {
            // ...hide things!
            buttonWarningText.enabled = false;
            isPlayerCharacterNextToButton = false;
        }
    }
}
