using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderWebInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("projectile"))
        {
            gameObject.SetActive(false);
            Destroy(collider.gameObject);
        }
    }
}
