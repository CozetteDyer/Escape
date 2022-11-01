using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonAlphabet : MonoBehaviour
{
    private char[] alphabet = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 
           'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 
            'U', 'V', 'W', 'X', 'Y', 'Z'};

    private TMP_Text ButtonText0;
    private TMP_Text ButtonText1;
    private TMP_Text ButtonText2;
    private TMP_Text ButtonText3;

    private int statusButton0 = 0;
    private int statusButton1 = 0;
    private int statusButton2 = 0;
    private int statusButton3 = 0;

    private GameObject hiddenDoor;


    private void Start()
    {
        ButtonText0 = GameObject.Find("ButtonText0").GetComponent<TMP_Text>();
        ButtonText1 = GameObject.Find("ButtonText1").GetComponent<TMP_Text>();
        ButtonText2 = GameObject.Find("ButtonText2").GetComponent<TMP_Text>();
        ButtonText3 = GameObject.Find("ButtonText3").GetComponent<TMP_Text>();
        hiddenDoor = GameObject.Find("ExitDoor");
        hiddenDoor.SetActive(false);
    }

    private void CheckAnswer()
    {
        if (statusButton0 == 4 && statusButton1 == 23 && statusButton2 == 8 && statusButton3 == 19)
        {
            hiddenDoor.SetActive(true);
        }
    }

    public void ButtonHandler0()
    {
        statusButton0 = (statusButton0 != 25) ? statusButton0 + 1 : 0;
        ButtonText0.text = alphabet[statusButton0].ToString();
        CheckAnswer();
    }

    public void ButtonHandler1()
    {
        statusButton1 = (statusButton1 != 25) ? statusButton1 + 1 : 0;
        ButtonText1.text = alphabet[statusButton1].ToString();
        CheckAnswer();
    }

    public void ButtonHandler2()
    {
        statusButton2 = (statusButton2 != 25) ? statusButton2 + 1 : 0;
        ButtonText2.text = alphabet[statusButton2].ToString();
        CheckAnswer();
    }

    public void ButtonHandler3()
    {
        statusButton3 = (statusButton3 != 25) ? statusButton3 + 1 : 0;
        ButtonText3.text = alphabet[statusButton3].ToString();
        CheckAnswer();
    }

}
