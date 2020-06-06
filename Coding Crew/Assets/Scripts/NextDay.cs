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
        PlayerPrefs.SetInt("Day", PlayerPrefs.GetInt("Day") + 1);
        Debug.Log(PlayerPrefs.GetInt("Day"));

        ChooseScene();
    }

    private void ChooseScene()
    {
        if(PlayerPrefs.GetInt("Day") == 2)
            SceneManager.LoadScene("LClassroom2");
        else if (PlayerPrefs.GetInt("Day") == 3)
            SceneManager.LoadScene("LClassroom3");

    }
}
