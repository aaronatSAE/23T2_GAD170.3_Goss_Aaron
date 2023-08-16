using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JellyArea : MonoBehaviour
{
    public TextMeshPro textBox;

    private void Start()
    {
        if(textBox != null)
        {
            Debug.Log("I have disabled the text box. Lots of love, from yours truly, " + gameObject.name);
            textBox.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("YOU HAVE ENTERED THE JELLY");

        GetComponent<Renderer>().material.color = Color.red;

        //other.transform.position = new Vector3(0, 1, 0);

        // Restart the scene!
        //UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        textBox.enabled = true;
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("YOU ARE IN THE JELLY");

        //GetComponent<Renderer>().material.color = Random.ColorHSV();
        transform.localScale = Vector3.one * 8 * Random.Range(1.1f, 2f);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("YOU HAVE LEFT THE JELLY");

        GetComponent<Renderer>().material.color = Color.yellow;
    }
}
