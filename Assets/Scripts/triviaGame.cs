using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triviaGame : MonoBehaviour
{
    // Start is called before the first frame update
	private GameObject hiddenCanvas;
    void Start()
    {
        hiddenCanvas = GameObject.Find("trivia_Canvas");
        hiddenCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        print("the game begins");
        if (GetComponent<Collider>().CompareTag("villain")) 
        {
            print("villian spotted");
            gameObject.SetActive(false);
            hiddenCanvas.SetActive(true);
            //Destroy(collider.gameObject);
            //GameObject.Find("Blocker").SetActive(false);
        }
    }
}