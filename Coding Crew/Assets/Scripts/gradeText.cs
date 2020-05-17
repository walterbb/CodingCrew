using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gradeText : MonoBehaviour
{
    Text grade;

    // Start is called before the first frame update
    void Start()
    {
        grade = GetComponent<Text>();

        grade.text = TestChecker.instance.percentCorrect.ToString("F0") + "%";
    }

    
}
