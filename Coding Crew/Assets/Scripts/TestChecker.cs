using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TestChecker : MonoBehaviour
{

    public static TestChecker instance;

    public TestMaker TM;

    public int Q1Choice, Q2Choice, Q3Choice, Q4Choice;

    private List<string> RightAnswers = new List<string> { "7", "Purple", "Frozen", "May 4th", "North West", "Africa", "3", "12", "invincible",
    "7", "13", "June 12th", "Red", "Dog", "3", "Coffee Mug", "Oslo", "94 Million", "Giuliano", "Kanye West", "1", "Alex"};

    private string playerAnswer1, playerAnswer2, playerAnswer3, playerAnswer4;

    private bool Q1Correct,Q2Correct,Q3Correct,Q4Correct;

    public float percentCorrect = 0;

    private void Awake()
    {
        instance = this;
    }


    public void Update()

    {

        int numCorrect = 0;

        if(Q1Correct)
        {
            numCorrect++;
        }

        if (Q2Correct)
        {
            numCorrect++;
        }

        if (Q3Correct)
        {
            numCorrect++;
        }

        if (Q4Correct)
        {
            numCorrect++;
        }

        percentCorrect = (numCorrect / 4f) * 100f;
    }

    

    public void Q1Select()
    {
        Text pickText1 = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>();
        playerAnswer1 = pickText1.text;

        foreach (string a in RightAnswers)
        {
            if(playerAnswer1 == a)
            {
                Q1Correct = true;
                break;
            }
            else
            {
                Q1Correct = false;
            }
        }
    }

    public void Q2Select()
    {
        Text pickText2 = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>();
        playerAnswer2 = pickText2.text;

        foreach (string a in RightAnswers)
        {
            if (playerAnswer2 == a)
            {
                Q2Correct = true;
                break;
            }
            else
            {
                Q2Correct = false;
            }
        }
    }

    public void Q3Select()
    {
        Text pickText3 = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>();
        playerAnswer3 = pickText3.text;

        foreach (string a in RightAnswers)
        {
            if (playerAnswer3 == a)
            {
                Q3Correct = true;
                break;
            }
            else
            {
                Q3Correct = false;
            }
        }
    }

    public void Q4Select()
    {
        Text pickText4 = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>();
        playerAnswer4 = pickText4.text;

        foreach (string a in RightAnswers)
        {
            if (playerAnswer4 == a)
            {
                Q4Correct = true;
                break;
            }
            else
            {
                Q4Correct = false;
            }
        }
    }
}
