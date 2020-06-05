using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class WakeUpManager : MonoBehaviour
{
	public float sleepDelay;
	public float delayTimer;

	public bool wakeUp;

	private VideoPlayer videoPlayer;
	private bool clipPlayed;

	public GameObject blackPanel;

	public CamController cam;

	void Start()
    {
		delayTimer = 0f;
		wakeUp = false;

		blackPanel.SetActive(true);

		cam.yClamp = 5f;
		cam.xClampDown = 40f;
		cam.xClampUp = 30f;

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
			cam.yClamp = 50f;
			cam.xClampDown = 40f;
			cam.xClampUp = -35f;
		}

		if(delayTimer >= sleepDelay + 0.4f) // Toggle Black Screen off after a slight delay
		{
			blackPanel.SetActive(false);
		}

		if(delayTimer >= sleepDelay + videoPlayer.clip.length)
		{
			wakeUp = true;
			cam.yClamp = 170f;
			cam.xClampDown = 65f;
			cam.xClampUp = -40f;
		}
    }
}
