using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestMaker : MonoBehaviour
{

    public Text question1;

    public Test test;

    public Text answer1, answer2;

    public GameObject allTest;

    // Start is called before the first frame update
    void Start()
    {
        int Qnum = Random.Range(0, 3);

        switch(Qnum)
        {
            case 0:
                question1.text = "What is 4 + 3?";
                answer1.text = "7";
                answer2.text = "10";
                break;
            case 1:
                question1.text = "What is blue + red?";
                answer1.text = "purple";
                answer2.text = "yellow";
                break;
            case 2:
                question1.text = "What are foreach loops?";
                answer1.text = "IDK";
                answer2.text = "DUMB";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(test.TestActive)
        {
            allTest.SetActive(true);
        }
        else if (!test.TestActive)
        {
            allTest.SetActive(false);
        }
    }
}
