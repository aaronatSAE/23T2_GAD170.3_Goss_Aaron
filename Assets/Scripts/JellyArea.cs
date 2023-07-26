using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("YOU HAVE ENTERED THE JELLY");

        GetComponent<Renderer>().material.color = Color.red;
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
