using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
	public TMP_Text text;

	public List<Sentence> sentences = new List<Sentence>();

	private int index;
	private bool sentenceComplete;

	public float textSpeed;

	public float timer;

	public DialogSounds sounds;

    void Start()
    {
		text.text = "";

		index = 0;
		sentenceComplete = true;

		timer = 0f;
    }

    void Update()
    {
		timer += Time.deltaTime;

		SentenceUpdate();
    }

	IEnumerator Type()
	{
		text.text = "";

		sentenceComplete = false;
		foreach (char letter in sentences[index].sentence.ToCharArray())
		{
			text.text += letter;

			float t = sounds.CharToSound(letter);

			if (t > textSpeed) yield return new WaitForSeconds(t);
			else yield return new WaitForSeconds(textSpeed);
		}
		yield return new WaitForSeconds(1f);

		text.text = "";

		if (index < sentences.Count - 1)
		{
			index++;
			sentenceComplete = true;
		}
		else sentenceComplete = false;
	}

	void SentenceUpdate()
	{
		if(sentenceComplete)
		{
			if(timer >= sentences[index].time)
			{
				StartCoroutine(Type());
			}
		}
	}
}
