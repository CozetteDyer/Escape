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
    }
}