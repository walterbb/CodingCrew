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
    private string[] Q1Questions = new string[] { "What is 4 + 3?", "What is blue + red?", "What Mr. Willis' favorite movie"};
    public readonly string[] q1answer1 =
        new string[] {"70","1","7","12"};
    public readonly string[] q1answer2 =
        new string[] { "Purple", "Pink", "Green", "Yellow" };
    public readonly string[] q1answer3 =
        new string[] { "Ponyo", "Frozen", "Finding Nemo", "Lion King" };

    public Text question2;
    public List<Text> answersText2;
    private string[] Q2Questions = new string[] { "What is the date?", "Where is Oregon in the U.S?", "What does MWIS stand for?" };
    public readonly string[] q2answer1 =
        new string[] { "June 12th", "November 15th", "November 5th", "June 14th"};
    public readonly string[] q2answer2 =
        new string[] { "North West", "South East", "Not in the U.S", "North East" };
    public readonly string[] q2answer3 =
        new string[] { "Mr. Willis Is Cool", "Mr. Willis Invented Cool", "Math Work Is Super", "Math Will Impower Students" };

    public Text question3;
    public List<Text> answersText3;
    private string[] Q3Questions = new string[] { "How many vehichles are outside?", "% =  X What is X?", "Word Of The Day?" };
    public readonly string[] q3answer1 =
        new string[] { "3", "10", "0", "1" };
    public readonly string[] q3answer2 =
        new string[] { "2", "34", "12", "43" };
    public readonly string[] q3answer3 =
        new string[] { "invisible", "invincible", "important", "inconsequential" };

    public Text question4;
    public List<Text> answersText4;
    private string[] Q4Questions = new string[] { "How many Posters are in the room?", "X + Y = 10, what is X equal to?", "When is Luke's birthday?" };
    public readonly string[] q4answer1 =
        new string[] { "0", "5", "10", "11" };
    public readonly string[] q4answer2 =
        new string[] { "13", "-5", "10", "392" };
    public readonly string[] q4answer3 =
        new string[] { "July 6th", "June 12th", "October 4th", "July 16th" };

    // Start is called before the first frame update
    void Start()
    {
        Question1Set();
        Question2Set();
        Question3Set();
        Question4Set();
    }

    void Question1Set()
    {
        int Qnum = Random.Range(0, Q1Questions.Length);

        tc.Q1Choice = Qnum;

        switch (Qnum)
        {
            case 0:
                question1.text = Q1Questions[Qnum];
                for (int i = 0; i < answersText1.Count; i++)
                {
                    answersText1[i].text = q1answer1[i];
                }
                break;
            case 1:
                question1.text = Q1Questions[Qnum];
                for (int i = 0; i < answersText1.Count; i++)
                {
                    answersText1[i].text = q1answer2[i];
                }
                break;
            case 2:
                question1.text = Q1Questions[Qnum];
                for (int i = 0; i < answersText2.Count; i++)
                {
                    answersText1[i].text = q1answer3[i];
                }
                break;
        }
    }

    void Question2Set()
    {
        int Qnum = Random.Range(0, Q2Questions.Length);
        tc.Q2Choice = Qnum;

        switch (Qnum)
        {
            case 0:
                question2.text = Q2Questions[Qnum];
                for (int i = 0; i < answersText2.Count; i++)
                {
                    answersText2[i].text = q2answer1[i];
                }
                break;
            case 1:
                question2.text = Q2Questions[Qnum];
                for (int i = 0; i < answersText2.Count; i++)
                {
                    answersText2[i].text = q2answer2[i];
                }
                break;
            case 2:
                question2.text = Q2Questions[Qnum];
                for (int i = 0; i < answersText2.Count; i++)
                {
                    answersText2[i].text = q2answer3[i];
                }
                break;
        }
    }

    void Question3Set()
    {
        int Qnum = Random.Range(0, Q3Questions.Length);
        tc.Q3Choice = Qnum;

        switch (Qnum)
        {
            case 0:
                question3.text = Q3Questions[Qnum];
                for (int i = 0; i < answersText3.Count; i++)
                {
                    answersText3[i].text = q3answer1[i];
                }
                break;
            case 1:
                question3.text = Q3Questions[Qnum];
                for (int i = 0; i < answersText3.Count; i++)
                {
                    answersText3[i].text = q3answer2[i];
                }
                break;
            case 2:
                question3.text = Q3Questions[Qnum];
                for (int i = 0; i < answersText3.Count; i++)
                {
                    answersText3[i].text = q3answer3[i];
                }
                break;
        }
    }

    void Question4Set()
    {
        int Qnum = Random.Range(0, Q4Questions.Length);
        tc.Q4Choice = Qnum;

        switch (Qnum)
        {
            case 0:
                question4.text = Q4Questions[Qnum];
                for (int i = 0; i < answersText4.Count; i++)
                {
                    answersText4[i].text = q4answer1[i];
                }
                break;
            case 1:
                question4.text = Q4Questions[Qnum];
                for (int i = 0; i < answersText4.Count; i++)
                {
                    answersText4[i].text = q4answer2[i];
                }
                break;
            case 2:
                question4.text = Q4Questions[Qnum];
                for (int i = 0; i < answersText3.Count; i++)
                {
                    answersText4[i].text = q4answer3[i];
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
