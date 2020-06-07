using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestMaker : MonoBehaviour
{
    
    public TestChecker tc;

    private int Qnum;

    public List<string> Questions = new List<string> {"What is 4 + 3?", "What is blue + red?", "What Mr. Willis' favorite movie", "What is the date?",
        "Where is Oregon in the U.S?", "What does MWIS stand for?", "How many vehichles are outside?", "% = Z*2 What is %?", "Word Of The Day?",
        "How many Posters are in the room?", "X + Y = 10, what is X equal to?", "When is Mr.Willis' birthday?", "What color is Mr. Willis' shirt?", "What pet does Mr. Willis' not own?", "What is  3 + 2/9 * 0",
        "What is on Mr. Willis' desk?", "What is the capital of Norway?", "How many miles is the Earth from the Sun?", "Who isn't a creator of the game?", "Which is not a stage name?", "How many tree stumps are outside?",
        "What is Mr. Willis' first name?"};

    public List<string[]> Answers = new List<string[]> { new string[] { "70", "20", "7", "12" }, new string[] { "Purple", "Pink", "Green", "Yellow" },
        new string[] { "Ponyo", "Frozen", "Finding Nemo", "Lion King" }, new string[] { "June 21th", "November 15th", "November 5th", "November 4th"},
        new string[] { "North West", "South East", "Not in the U.S", "North East" }, new string[] { "Mr. Willis Is Cool", "Mr. Willis Invented Cool", "Math Work Is Super", "Math Will Impower Students" },
        new string[] { "3", "10", "0", "1" },new string[] { "2", "34", "12", "43" }, new string[] { "invisible", "invincible", "important", "inconsequential" },
        new string[] { "0", "5", "10", "11" }, new string[] { "13", "-5", "10", "392" },new string[] { "July 6th", "June 12th", "October 4th", "July 16th" }, new string[] { "Blue", "Red", "Yellow", "Green" },
        new string[] { "Dog", "Lemur", "Crocidile", "Monkey" }, new string[] { "3", "0", "2/3", ".245" }, new string[] { "Pencils", "Papers", "Apple", "Coffee Mug" },new string[] { "Oslo", "Burgen", "Lillehammer", "Kroger"},
        new string[] { "94 Million", "6 Million", "2 Light Years", "84 Billion" }, new string[] { "Luke", "Walt", "Matthew", "Giuliano" }, new string[] { "Lady Gaga", "Jamie Foxx", "Katy Perry", "Kanye West" },
        new string[] { "2", "5", "4", "1" }, new string[] { "Alan", "Arnold", "Adam", "Alex" }};



    public Text question1;
    public List<Text> answersText1;

    public Text question2;
    public List<Text> answersText2;
    
    public Text question3;
    public List<Text> answersText3;
    
    public Text question4;
    public List<Text> answersText4;

    int Qcount = 0;

    List<int> Rands = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("randnums", (PlayerPrefs.GetInt("Day") - 1) * 4);
        for (int i = 0; i < PlayerPrefs.GetInt("randnums"); i++)
        {
            int temp = PlayerPrefs.GetInt("randnums" + i);
            Questions.Remove(Questions[PlayerPrefs.GetInt("randnums"+i)]);
            Answers.Remove(Answers[PlayerPrefs.GetInt("randnums" + i)]);
            Debug.Log("randnums" + i+ ": " + temp);
        }
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

        
        Rands.Add(rand);

        int totalrands = PlayerPrefs.GetInt("randnums");
        PlayerPrefs.SetInt("randnums" + (Qcount + totalrands), rand);
        Debug.Log(rand);
        Debug.Log("randnums" + (Qcount + totalrands) + ": " + PlayerPrefs.GetInt("randnums" + (Qcount + totalrands), rand));

        //PlayerPrefs.SetInt("randnums", totalrands);

        //for (int i = 0; i < Rands.Count; i++)
        //{
        //    PlayerPrefs.SetInt("randnums" + i+ totalrands, Rands[i]);
        //}

    }


    // Update is called once per frame
    void Update()
    {
      
    }

}
