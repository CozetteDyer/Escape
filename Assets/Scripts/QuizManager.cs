using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    public List<QandA> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public Text questionText;

    private void Start()
    {

    }

    void setAnswers()
    {


    }

    void generateQuestion()
    {
        currentQuestion = Random.Range(0,QnA.Count); // 5 questions for now

        questionText.text = QnA[currentQuestion].Question;
    }


}
