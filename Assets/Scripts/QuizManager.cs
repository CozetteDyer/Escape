using System.Collections;
using System.Collections.Generic;  
using UnityEngine;
using UnityEngine.UI; 
using TMPro;

public class QuizManager : MonoBehaviour
{
    public List<QuestionandAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public int qCorrect;

    public GameObject QuizPanel;
    public GameObject GoPanel; // Game Over
    public GameObject WPanel; // winner panel


	public TMP_Text questionText;

    private void Start()
    {
        GoPanel.SetActive(false);
        WPanel.SetActive(false);
        generateQuestion();
    }

    void generateQuestion()
    {
        if(QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count); // 5 questions for now

            questionText.text = QnA[currentQuestion].Question;
            setAnswers();
        }
        else
        {
            Debug.Log("oops, out of questions");
            gameOver();
        }
    }

    
    void gameOver()
    {
        QuizPanel.SetActive(false);
        GoPanel.SetActive(true);
    }

    public void correct()
    {
        qCorrect += 1;
   
        if (qCorrect == 3)
        {
            QuizPanel.SetActive(false);
            GoPanel.SetActive(false);
            WPanel.SetActive(true);
        }
             
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }
    
    
    void setAnswers()
    {
        for(int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswersScript>().isCorrect = false; 
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[currentQuestion].Answers[i];

            if(QnA[currentQuestion].correctAnswer == i)
            {
                options[i].GetComponent<AnswersScript>().isCorrect = true; 
            }
       
        }

    }

}
