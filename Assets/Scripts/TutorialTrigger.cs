using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TutorialTrigger : MonoBehaviour
{
    // When the player character enters this zone,
    // display the tutorial text!

    [SerializeField] private TextMeshPro tutorialText;

    [SerializeField] private GameObject[] arrayOfTextObjects;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER has been TRIGGERED!");

        // if the player character triggers this method...
        if (other.CompareTag("Player"))
        {
            // ...show the tutorial text!
            tutorialText.enabled = true;

            for (int i = 0; i < 1000; i++)
            {
                Debug.Log("HELLO THIS IS THE NUMBER: " + i);
            }
        }
    }
}
