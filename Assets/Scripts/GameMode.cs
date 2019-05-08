using System;
using Vuforia;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameMode : MonoBehaviour{

    public string[] basicQuestions;
    public string[] mediumQuestions;
    public string[] extremeQuestions;
    public string chosenQuestion;
    public string question;
    public string title;
    public int Bottleback;

    public Transform ARObject;
    public Transform basicObject;
    public Transform mediumObject;
    public Transform extremeObject;
    public Transform scanObject;

    public Text basicQuestionText;
    public Text mediumQuestionText;
    public Text extremeQuestionText;

    public Text basicTitleText;
    public Text mediumTitleText;
    public Text extremeTitleText;

    public Text BasicQuestionType; // ON APP LOAD WHAT THIS TO BE HIDEN OR DIFFRENT VALUE
    public string BasicQuestionTypeVal = "BASIC";



    // Use this for initialization
	void Start () {
	}


	// Update is called once per frame
	void Update () {
	}


    public void RandQuestion(int questionType)
    {
        Debug.Log("hello");
        switch (questionType)
        {
            case 0:
                chosenQuestion = basicQuestions[UnityEngine.Random.Range(0, basicQuestions.Length - 1)];
                splitText(chosenQuestion);
                Bottleback = 0;
                ARObject.gameObject.SetActive(false);
                basicQuestionText.text = question.ToString();
                BasicQuestionType.fontSize = 100;
                BasicQuestionType.text = BasicQuestionTypeVal.ToString();
                basicTitleText.text = title;
                basicObject.gameObject.SetActive(true);
                Debug.Log(questionType);
                break;

            case 1:
                chosenQuestion = mediumQuestions[UnityEngine.Random.Range(0, mediumQuestions.Length - 1)];
                splitText(chosenQuestion);
                Bottleback = 1;
                ARObject.gameObject.SetActive(false);
                mediumQuestionText.text = question.ToString();
                mediumObject.gameObject.SetActive(true);
                mediumTitleText.text = title;
                Debug.Log(questionType);
                break;

            case 2:
                chosenQuestion = extremeQuestions[UnityEngine.Random.Range(0, extremeQuestions.Length - 1)];
                splitText(chosenQuestion);
                Bottleback = 2;
                ARObject.gameObject.SetActive(false);
                extremeQuestionText.text = question.ToString();
                extremeObject.gameObject.SetActive(true);
                extremeTitleText.text = title;
                Debug.Log(questionType);
                break;
        }
    }

    public void splitText(string i){ ///chosen question
        string[] split = i.Split(new Char[] {'-'});
        title = split[0];
        question = split[1];
    }
}
    
