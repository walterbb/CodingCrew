using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogScript : MonoBehaviour
{
	public DialogManager dialogManager;

	public List<Sentence> sentencesDay01 = new List<Sentence> {new Sentence("Hi, I'm Mr. Willis, welcome to math class.",8f), new Sentence("Your goal is to pass this class.",9f)};

	void Start()
    {
		dialogManager.sentences = sentencesDay01;
    }
}
