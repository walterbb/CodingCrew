using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogScript : MonoBehaviour
{
	public DialogManager dialogManager;

	void Start()
    {
		int day = PlayerPrefs.GetInt("Day");

		switch(day)
		{
			case 1:
				dialogManager.sentences = sentencesDay01;
				break;
			case 2:
				dialogManager.sentences = sentencesDay02;
				break;
            default:
                dialogManager.sentences = sentencesDay02;
                break;
		}

		
    }

	public List<Sentence> sentencesDay01 = new List<Sentence> {
		new Sentence("Hi, I'm Mr. Willis, welcome to class.", 8.5f),
		new Sentence("To pass this class you have to pass each daily test.", 9f),
		new Sentence("Extra information can be found on posters and on the board.", 10f)



	};

	public List<Sentence> sentencesDay02 = new List<Sentence>
	{
		new Sentence("Hello class, welcome back.", 8.5f)
	};
}
