using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowTrivia : MonoBehaviour
{
    int hasShown = 0;
    GameObject trivaCanvas;
    //GameObject triviaBlock;
    //GameObject tryAgain;

    // Start is called before the first frame update
    void Start()
    {
        trivaCanvas = GameObject.Find("Trivia Canvas");
        //triviaBlock = GameObject.Find("TriviaBlock");
        //tryAgain = GameObject.Find("tryAgain");
        trivaCanvas.SetActive(false);
        //triviaBlock.SetActive(false);
        //tryAgain.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("villain") && hasShown == 0)
        {
            hasShown++;
            trivaCanvas.SetActive(true);
            //triviaBlock.SetActive(true);
        }
    }

  //  public void correct()
  //  {
        //triviaBlock.SetActive(false);
        //trivaCanvas.SetActive(false);
   // }

    //public void wrong()
    //{
      //  tryAgain.SetActive(true);
    //}
}
