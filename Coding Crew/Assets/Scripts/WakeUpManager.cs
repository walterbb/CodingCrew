using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class WakeUpManager : MonoBehaviour
{
	public float sleepDelay;
	private float delayTimer;

	public bool wakeUp;

	private VideoPlayer videoPlayer;
	private bool clipPlayed;

	public GameObject blackPanel;

	void Start()
    {
		delayTimer = 0f;
		wakeUp = false;

		videoPlayer = GetComponent<VideoPlayer>();
		clipPlayed = false;
    }

 
    void Update()
    {
		delayTimer += Time.deltaTime;

		if(delayTimer >= sleepDelay && !clipPlayed) // Start Video Playback
		{
			videoPlayer.Play();
			clipPlayed = true;
		}

		if(delayTimer >= sleepDelay + 0.1f) // Toggle Black Screen off after a slight delay
		{
			blackPanel.SetActive(false);
		}

		if(delayTimer >= sleepDelay + videoPlayer.clip.length)
		{
			wakeUp = true;
		}
    }
}
