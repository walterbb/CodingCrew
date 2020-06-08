using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DialogSounds : MonoBehaviour
{
	public AudioClip[] aoSounds;
	public AudioClip[] eoSounds;
	public AudioClip[] eSounds;
	public AudioClip[] ioSounds;
	public AudioClip[] uoSounds;
	public AudioClip[] oSounds;
	public AudioClip[] rSounds;
	public AudioClip[] spaces;
	public AudioClip[] punctuation;

	public AudioSource audioSource;

	public float CharToSound(char letter) // Plays a sound based on the character and returns the sound length
	{
		int c = Char.ToLower(letter); // Get the lower case ascii value of the letter

		// Play a sound based on the character value:
		if (c == 97 || c == 104 || c == 106 || c == 107) // ao sound
		{
			audioSource.clip = aoSounds[0];
			audioSource.Play();
		}
		else if (c > 97 && c < 102 || c == 103 || c == 112 || c == 116 || c == 118 || c == 122) // eo sound
		{
			audioSource.clip = eoSounds[0];
			audioSource.Play();
		}
		else if (c == 102 || c > 107 && c < 111 || c == 115 || c == 120) // e sound
		{
			audioSource.clip = eSounds[0];
			audioSource.Play();
		}
		else if (c == 105 || c == 121) // io sound
		{
			audioSource.clip = ioSounds[0];
			audioSource.Play();
		}
		else if (c == 113 || c == 117 || c == 119) // uo sound
		{
			audioSource.clip = uoSounds[0];
			audioSource.Play();
		}
		else if (c == 111) // o sound
		{
			audioSource.clip = oSounds[0];
			audioSource.Play();
		}
		else if (c == 114) // r sound
		{
			audioSource.clip = rSounds[0];
			audioSource.Play();
			//Debug.Log("r");
		}
		else if(c == 32)
		{
			int rand = UnityEngine.Random.Range(0,10);
			if(rand == 0)
			{
				audioSource.clip = spaces[0];
				audioSource.Play();
			}
		}
		else
		{
			audioSource.clip = punctuation[0];
			audioSource.Play();
		}

		return audioSource.clip.length;
	}
}
