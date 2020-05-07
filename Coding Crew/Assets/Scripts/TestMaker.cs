using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestMaker : MonoBehaviour
{
    public Test test;
    public GameObject allTest;
    public TestChecker tc;

    
    public Text question1;
    public List<Text> answersText1;
    public readonly string[] q1answer1 = new string[] {"70","1","7","12"};
    public readonly string[] q1answer2 = new string[] { "Purple", "Pink", "Green", "Yellow" };
    public readonly string[] q1answer3 = new string[] { "Elephant", "Blue Whale", "Dog", "Lion" };

    public Text question2;
    public List<Text> answersText2;
    public readonly string[] q2answer1 = new string[] { "Doesn't know for each", "Hasn't finished the game", "He's not :)", "Hot people are dumb"};
    public readonly string[] q2answer2 = new string[] { "Left", "South East", "Home", "South of Cali" };
    public readonly string[] q2answer3 = new string[] { "Learn o Lot", "Laughing out Loud", "Lots of Love", "Luke is cool" };

    public Text question3;
    public List<Text> answersText3;
    public readonly string[] q3answer1 = new string[] { "He's too cool", "Wanted to make money", "Got nervous because we were cute", "Hates Luke" };
    public readonly string[] q3answer2 = new string[] { "12", "Order 66", "36", "0" };
    public readonly string[] q3answer3 = new string[] { "Light Blue", "Blue", "Baby Blue", "Dark Blue" };

    // Start is called before the first frame update
    void Start()
    {
        Question1Set();
        Question2Set();
        Question3Set();
    }

    void Question1Set()
    {
        int Qnum = Random.Range(0, 3);

        tc.Q1Choice = Qnum;

        switch (Qnum)
        {
            case 0:
                question1.text = "What is 4 + 3?";
                for (int i = 0; i < answersText1.Count; i++)
                {
                    answersText1[i].text = q1answer1[i];
                }
                break;
            case 1:
                question1.text = "What is blue + red?";
                for (int i = 0; i < answersText1.Count; i++)
                {
                    answersText1[i].text = q1answer2[i];
                }
                break;
            case 2:
                question1.text = "What's the biggest animal?";
                for (int i = 0; i < answersText2.Count; i++)
                {
                    answersText1[i].text = q1answer3[i];
                }
                break;
        }
    }

    void Question2Set()
    {
        int Qnum = Random.Range(0, 3);
        tc.Q2Choice = Qnum;

        switch (Qnum)
        {
            case 0:
                question2.text = "Why is Walt dumb?";
                for (int i = 0; i < answersText2.Count; i++)
                {
                    answersText2[i].text = q2answer1[i];
                }
                break;
            case 1:
                question2.text = "Where is Oregon?";
                for (int i = 0; i < answersText2.Count; i++)
                {
                    answersText2[i].text = q2answer2[i];
                }
                break;
            case 2:
                question2.text = "What does LOL stand for?";
                for (int i = 0; i < answersText2.Count; i++)
                {
                    answersText2[i].text = q2answer3[i];
                }
                break;
        }
    }

    void Question3Set()
    {
        int Qnum = Random.Range(0, 3);
        tc.Q3Choice = Qnum;

        switch (Qnum)
        {
            case 0:
                question3.text = "Gugu left our group because...";
                for (int i = 0; i < answersText3.Count; i++)
                {
                    answersText3[i].text = q3answer1[i];
                }
                break;
            case 1:
                question3.text = "6 + 6?";
                for (int i = 0; i < answersText3.Count; i++)
                {
                    answersText3[i].text = q3answer2[i];
                }
                break;
            case 2:
                question3.text = "Lukes favorite color?";
                for (int i = 0; i < answersText3.Count; i++)
                {
                    answersText3[i].text = q3answer3[i];
                }
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(test.TestActive)
        {
            allTest.SetActive(true);
        }
        else if (!test.TestActive)
        {
            allTest.SetActive(false);
        }
    }
}
