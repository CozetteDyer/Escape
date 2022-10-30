using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunflowerHit : MonoBehaviour
{
    private GameObject hiddenSword;
    // Start is called before the first frame update
    void Start()
    {
        hiddenSword = GameObject.Find("HiddenSword");
        hiddenSword.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        print("intrigger");
        if (collider.CompareTag("projectile"))
        {
            print("INCompare");
            gameObject.SetActive(false);
            hiddenSword.SetActive(true);
            Destroy(collider.gameObject);
            GameObject.Find("Blocker").SetActive(false);
        }
    }
}
