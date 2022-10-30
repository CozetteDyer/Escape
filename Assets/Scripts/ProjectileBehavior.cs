using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float Speed = 4.5f;
    Vector3 movement;
    // Update is called once per frame
    private void Start()
    {
        movement = transform.right * Time.deltaTime * Speed;
        if (GameObject.Find("player").transform.localScale.x < 0){
            movement = movement * -1;
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }

    void Update()
    {
        transform.position += movement;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "wall" || collider.tag == "target")
        {
            Destroy(gameObject);
        }
    }
}


