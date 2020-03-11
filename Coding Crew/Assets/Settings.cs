using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public Toggle FullScreen;
    public Slider Volume;
    public AudioMixer mixer;
    public AudioSource groovy;

    public void Awake()
    {
        groovy.playOnAwake = true;
        groovy.loop = true;

    }
    // Start is called before the first frame update
    public void SetVolume(float sliderVal)
    {
        mixer.SetFloat("GameVolume", Mathf.Log10(sliderVal) * 20);
    }

    // Update is called once per frame
    void Update()
    {
        

        if( FullScreen.isOn)
        {
            Screen.fullScreen = true;
        }
        else if (!FullScreen.isOn)
        {
            Screen.fullScreen = false;
        }
    }
}
