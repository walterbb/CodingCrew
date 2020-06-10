using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestMaker : MonoBehaviour
{
    
    public TestChecker tc;

    private int Qnum;

    private List<string> Questions = new List<string> {"What is 4 + 3?", "What is blue + red?", "What Mr. Willis' favorite movie", "What is the date?",
        "Where is Oregon in the U.S?", "Where do Giraffes live in the wild?", "How many vehichles are outside?", "% = Z*2 What is %?", "Word Of The Day?",
        "How many Posters are in the room?", "X + Y = 10, what is X equal to?", "When is Mr.Willis' birthday?", "What color is Mr. Willis' shirt?", "What pet does Mr. Willis' not own?", "What is  3 + 2/9 * 0",
        "What is on Mr. Willis' desk?", "What is the capital of Norway?", "How many miles is the Earth from the Sun?", "Who isn't a creator of the game?", "Which is not a stage name?", "How many tree stumps are outside?",
        "What is Mr. Willis' first name?"};

    private List<string[]> Answers = new List<string[]> { new string[] { "70", "20", "7", "56" }, new string[] { "Purple", "Pink", "Green", "Yellow" },
        new string[] { "Ponyo", "Frozen", "Finding Nemo", "Lion King" }, new string[] { "June 21th", "July 15th", "June 5th", "May 4th"},
        new string[] { "North West", "South East", "South West", "North East" }, new string[] { "Antarctica", "Africa", "Australia", "Greenland" },
        new string[] { "3", "10", "0", "1" },new string[] { "2", "34", "12", "43" }, new string[] { "invisible", "invincible", "important", "invented" },
        new string[] { "0", "5", "7", "11" }, new string[] { "13", "-5", "6", "392" },new string[] { "July 6th", "June 12th", "July 4th", "July 16th" }, new string[] { "Blue", "Red", "Yellow", "Green" },
        new string[] { "Dog", "Lemur", "Crocidile", "Monkey" }, new string[] { "3", "0", "2/3", ".245" }, new string[] { "Pencils", "Papers", "Apple", "Coffee Mug" },new string[] { "Oslo", "Burgen", "Lillehammer", "Kroger"},
        new string[] { "94 Million", "6 Million", "2 Million", "84 Billion" }, new string[] { "Luke", "Walt", "Matthew", "Giuliano" }, new string[] { "Lady Gaga", "Jamie Foxx", "Katy Perry", "Kanye West" },
        new string[] { "2", "5", "4", "1" }, new string[] { "Alan", "Arnold", "Adam", "Alex" }};


	private List<string> answerInfo = new List<string>
	{
		"4 + 3 = 7", "Blue + Red = Purple", "Mr. Willis' favorite movie is Frozen", "The date is May 4th", "Oregon is located in the North West",
		"Africa is the only continent where Giraffes live in the wild", "Pluto is not a planet", "% = 12", "Word of the day: invincible",
		"The ocean is on average 2.3 miles deep", "X = 13", "Mr. Willis' birthday is June 12th", "Water boils at 100 Celcius", "Mr. Willis owns a Monkey, Crocodile and a Lemur",
		"Ottowa is the capital of Canada", "There are 206 bones in the human body", "Oslo is the capital of Norway", "The earth is 94 Million miles from the sun",
		"Created by: Luke, Walt, Matthew", "Yes! Kanye West is his real name.", "There are six sides on a cube", "Teacher of the Year: Alex Willis"
	};

	private List<string> answerInfoCurrent = new List<string>();
		 
	private List<string> dummyInfo = new List<string>
	{
		 "The Quran is the holy book of Muslims", "Bill Gates founded Microsoft", "Mercury is the closest planet to the sun", "Harvard is in Cambridge, Massachusetts",
		 "M = 56", "The Titanic sunk in 1912", "Nyctophobia is the fear of darkness", "Na is the symbol for Sodium", "Crabs are anthropods", "There are three parts of the brain",
		 "Obama was the 44th president of the US", "China has 23 provinces", "Shrek's wife is named Fiona", "Cinderella's name is Ella", "Minnie Mouse's best friend is Daisy Duck",
		 "The prime minister of Canada is Justin Trudaeu", "Backrub was the original name of Google", "Elmo has testified before Congress", "Nutella was invented in WW1",
		 "The Peregrine falcon is the fastest bird" , "Cows can sleep standing up", "USB stands for universal serial bus", "Entomology is the science of insects",
		 "Snakes can predict earthquakes"
	};

    public Text question1;
    public List<Text> answersText1;

    public Text question2;
    public List<Text> answersText2;
    
    public Text question3;
    public List<Text> answersText3;
    
    public Text question4;
    public List<Text> answersText4;

    int Qcount = 0;

	public Text[] posters;
	public Text[] board;

	public DialogManager dialog;

    List<int> Rands = new List<int>();

    void Start()
    {
        PlayerPrefs.SetInt("randnums", (PlayerPrefs.GetInt("Day") - 1) * 4);
        for (int i = 0; i < PlayerPrefs.GetInt("randnums"); i++)
        {
            int temp = PlayerPrefs.GetInt("randnums" + i);
            Questions.Remove(Questions[PlayerPrefs.GetInt("randnums"+i)]);
            Answers.Remove(Answers[PlayerPrefs.GetInt("randnums" + i)]);
			answerInfo.Remove(answerInfo[PlayerPrefs.GetInt("randnums" + i)]);
        }
		//Debug.Log("QNUM = " + Qnum + " AND PF =" + PlayerPrefs.GetInt("Day"));
        
        for (Qcount = 0; Qcount < 4; Qcount++)
        {
            QuestionSet();
        }

		SetInformation();
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

		answerInfoCurrent.Add(answerInfo[rand]);
		answerInfo.Remove(answerInfo[rand]);

        
        Rands.Add(rand);

        int totalrands = PlayerPrefs.GetInt("randnums");
        PlayerPrefs.SetInt("randnums" + (Qcount + totalrands), rand);
        //Debug.Log(rand);
        //Debug.Log("randnums" + (Qcount + totalrands) + ": " + PlayerPrefs.GetInt("randnums" + (Qcount + totalrands), rand));

        //PlayerPrefs.SetInt("randnums", totalrands);

        //for (int i = 0; i < Rands.Count; i++)
        //{
        //    PlayerPrefs.SetInt("randnums" + i+ totalrands, Rands[i]);
        //}

    }

	void SetInformation()
	{
		List<Text> answerPosters = new List<Text>();
		int boardCount = 0; 
		int dialogCount = 0; if (PlayerPrefs.GetInt("Day") == 1) dialogCount = 2;

		// Fill answer information
		for (int i = 0; i < 4; i++)
		{
			int rand = Random.Range(0, 4);
	
			
			if (rand == 2 && boardCount < 2) // Board chance
			{
				board[boardCount].text = answerInfoCurrent[i];
				boardCount++;
                Debug.Log("B "+ answerInfoCurrent[i] + rand);
                Debug.Log("B count " + boardCount);
            }
			else if (rand == 3 && dialogCount < 3) // Dialog chance
			{
				float t = (dialogCount + 2) * 10;
				dialog.sentences.Add(new Sentence(answerInfoCurrent[i], t));
				dialogCount++;
                Debug.Log("D " + answerInfoCurrent[i] + rand);
                Debug.Log("D count " + dialogCount);
            }
			else // Poster chance
			{

				int poster = Random.Range(0, posters.Length);
				posters[poster].text = answerInfoCurrent[i];
				answerPosters.Add(posters[poster]);
                
                Debug.Log("Poster " + answerInfoCurrent[i] + rand);
                Debug.Log("Poster count " + poster);
            }


		}

		// Fill dummy information
		foreach(Text t in posters) // Fill posters
		{
			bool answer = false;
			for(int j = 0; j < answerPosters.Count; j++)
			{
				if (t == answerPosters[j]) answer = true;
			}
			
			if(!answer)
			{
				int rand = Random.Range(0, dummyInfo.Count);
				t.text += dummyInfo[rand];
				dummyInfo.RemoveAt(rand);
			}
		}

		for(int k = boardCount; k < 3; k++) // Fill board
		{
			int rand = Random.Range(0, dummyInfo.Count);
			board[k].text += dummyInfo[rand];
			dummyInfo.RemoveAt(rand);
		}

		for(int l = dialogCount; l < 3; l++) // Fill dialog
		{
			float t = (l + 2) * 10;
			int rand = Random.Range(0, dummyInfo.Count);
			dialog.sentences.Add(new Sentence (dummyInfo[rand] ,t));
			dummyInfo.RemoveAt(rand);
		}
		
	}
}
