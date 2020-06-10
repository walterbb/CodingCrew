using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextDay : MonoBehaviour
{
    public static NextDay nextDay;

    public void Start()
    {
        nextDay = this;
    }

    // Start is called before the first frame update
    public void SceneSwitch()
    {
        if(PlayerPrefs.GetFloat("totalScore") / PlayerPrefs.GetInt("Day") >= 70 && PlayerPrefs.GetInt("Day") < 5)
        {
            PlayerPrefs.SetInt("Day", PlayerPrefs.GetInt("Day") + 1);
            ChooseScene();
        }
        else if(PlayerPrefs.GetFloat("totalScore") / PlayerPrefs.GetInt("Day") >= 70)
        {
            SceneManager.LoadScene("WinScene");
        }
        else if(PlayerPrefs.GetFloat("totalScore") / PlayerPrefs.GetInt("Day") < 70)
        {
            SceneManager.LoadScene("LoseScene");
        }
        
        Debug.Log(PlayerPrefs.GetInt("Day"));
    }

    private void ChooseScene()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Day"));
    }
}
