using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gradeText : MonoBehaviour
{
    public Text grade;
    public Text classGrade;
    
    float oldTotal = 0;
    // Start is called before the first frame update
    void Start()
    {
        grade.text = TestChecker.instance.percentCorrect.ToString("F0") + "%";


        if(PlayerPrefs.GetInt("Day") != 1)
        {
            oldTotal = PlayerPrefs.GetFloat("totalScore");
        }

        PlayerPrefs.SetFloat("totalScore", TestChecker.instance.percentCorrect + oldTotal);
        classGrade.text = (PlayerPrefs.GetFloat("totalScore") / PlayerPrefs.GetInt("Day")).ToString("F0") +"%";
        Debug.Log("oldTotal " + oldTotal);
        Debug.Log("percent correct " + TestChecker.instance.percentCorrect);
        Debug.Log("Day " + PlayerPrefs.GetInt("Day"));
    }
}
