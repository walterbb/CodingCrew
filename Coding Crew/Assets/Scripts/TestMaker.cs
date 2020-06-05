using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestMaker : MonoBehaviour
{
    public Test test;
    public GameObject allTest;
    public TestChecker tc;

    private int Qnum;

    public List<string> Questions = new List<string> {"What is 4 + 3?", "What is blue + red?", "What Mr. Willis' favorite movie", "What is the date?",
        "Where is Oregon in the U.S?", "What does MWIS stand for?", "How many vehichles are outside?", "% = Z*2 What is %?", "Word Of The Day?",
        "How many Posters are in the room?", "X + Y = 10, what is X equal to?", "When is Mr.Willis' birthday?"};

    public List<string[]> Answers = new List<string[]> { new string[] { "70", "1", "7", "12" }, new string[] { "Purple", "Pink", "Green", "Yellow" },
        new string[] { "Ponyo", "Frozen", "Finding Nemo", "Lion King" }, new string[] { "June 12th", "November 15th", "November 5th", "June 14th"},
        new string[] { "North West", "South East", "Not in the U.S", "North East" }, new string[] { "Mr. Willis Is Cool", "Mr. Willis Invented Cool", "Math Work Is Super", "Math Will Impower Students" },
        new string[] { "3", "10", "0", "1" },new string[] { "2", "34", "12", "43" }, new string[] { "invisible", "invincible", "important", "inconsequential" },
        new string[] { "0", "5", "10", "11" }, new string[] { "13", "-5", "10", "392" },new string[] { "July 6th", "June 12th", "October 4th", "July 16th" }};



    public Text question1;
    public List<Text> answersText1;

    public Text question2;
    public List<Text> answersText2;
    
    public Text question3;
    public List<Text> answersText3;
    
    public Text question4;
    public List<Text> answersText4;

    int Qcount = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        //Qnum = PlayerPrefs.GetInt("Day") - 1;
        //Debug.Log("QNUM = " + Qnum + " AND PF =" + PlayerPrefs.GetInt("Day"));

        for (Qcount = 0; Qcount < 4; Qcount++)
        {
            QuestionSet();
            
        }
    }


    void QuestionSet()
    {
        int rand = Random.Range(0, Questions.Count);
        
        if(Qcount == 0)
        {
            question1.text = Questions[rand];
            string[] currentAnswers = Answers[rand];

            for (int i = 0; i < answersText1.Count; i++)
            {
                answersText1[i].text = currentAnswers[i];
            }
        }

        if (Qcount == 1)
        {
            question2.text = Questions[rand];
            string[] currentAnswers = Answers[rand];

            for (int i = 0; i < answersText1.Count; i++)
            {
                answersText2[i].text = currentAnswers[i];
            }
        }

        if (Qcount == 2)
        {
            question3.text = Questions[rand];
            string[] currentAnswers = Answers[rand];

            for (int i = 0; i < answersText1.Count; i++)
            {
                answersText3[i].text = currentAnswers[i];
            }
        }

        if (Qcount == 3)
        {
            question4.text = Questions[rand];
            string[] currentAnswers = Answers[rand];

            for (int i = 0; i < answersText1.Count; i++)
            {
                answersText4[i].text = currentAnswers[i];
            }
        }

        Questions.Remove(Questions[rand]);
        Answers.Remove(Answers[rand]);
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
