using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
using TMPro;

public class GameManager : MonoBehaviour
{

    public Question[] questions;
    private static List<Question> unansweredQuestions;

    private Question currentQuestion;

    private int score;

    [SerializeField] TextMeshProUGUI m_Text;
    private Text questionText;

    [SerializeField]
    private float timeBetweenQuestions = 1f;

    private void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }

        SetCurrentQuestion();
        Debug.Log(currentQuestion.question + " is " + currentQuestion.isTrue);

    }

    // randomizes next questions
    void SetCurrentQuestion ()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        m_Text.text = currentQuestion.question;

    }

    // delay in next question
    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestions);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void UserSelectChoice1 ()
    {
        if (currentQuestion.isTrue)
        {
            Debug.Log("CHOICE 1!");
        } else
        {
            Debug.Log("CHOICE 2!");
        }

        StartCoroutine(TransitionToNextQuestion());
    }
    public void UserSelectChoice2 ()
    {
        if (!currentQuestion.isTrue)
        {
            Debug.Log("CHOICE 1!");
        }
        else
        {
            Debug.Log("CHOICE 2!");
        }
        StartCoroutine(TransitionToNextQuestion());
    }




}
