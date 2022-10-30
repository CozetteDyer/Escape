using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onTriggerEnter : MonoBehaviour
{
    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Door"))
        {
            SceneManager.LoadScene("2nd room");
        }

 	if (collision.CompareTag("doorTest"))
        {
            SceneManager.LoadScene("3rd room");
        }

	if (collision.CompareTag("barrelTest"))
        {
            SceneManager.LoadScene("1st room");
        }

	if (collision.CompareTag("villain"))
        {
	    Debug.Log ("toggle");
        }

    }
}