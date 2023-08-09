using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TutorialTrigger : MonoBehaviour
{
    // When the player character enters this zone,
    // display the tutorial text!

    [SerializeField] private TextMeshPro tutorialText;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER has been TRIGGERED!");

        // if the player character triggers this method...
        if (other.CompareTag("Player"))
        {
            // ...show the tutorial text!
            tutorialText.enabled = true;
        }
    }
}
