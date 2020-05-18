using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TestChecker : MonoBehaviour
{

    public static TestChecker instance;

    public TestMaker TM;

    public int Q1Choice, Q2Choice, Q3Choice, Q4Choice;

    private bool[] Q1Picked = new bool[] { false, false, false, false };
    private bool[] Q2Picked = new bool[] { false, false, false, false };
    private bool[] Q3Picked = new bool[] { false, false, false, false };
    private bool[] Q4Picked = new bool[] { false, false, false, false };

	private bool[] falseList = new bool[] { false, false, false, false };

    private bool Q1Correct,Q2Correct,Q3Correct,Q4Correct;

    public float percentCorrect = 0;

    private void Awake()
    {
        instance = this;
    }

    public void Update()
    {
        Q1TestCheck();
        Q2TestCheck();
        Q3TestCheck();
        Q4TestCheck();

        int numCorrect = 0;

        if(Q1Correct)
        {
            numCorrect++;
        }

        if (Q2Correct)
        {
            numCorrect++;
        }

        if (Q3Correct)
        {
            numCorrect++;
        }

        if (Q4Correct)
        {
            numCorrect++;
        }


        percentCorrect = (numCorrect / 4f) * 100f;

        print(percentCorrect.ToString("F0") + "%");
    }

    void Q1TestCheck()
    {
        switch(Q1Choice)
        {
            case 0:
                if (Q1Picked[2])
                {
                    Q1Correct = true;
                }
                else
                {
                    Q1Correct = false;
                }
                break;
            case 1:
                if (Q1Picked[0])
                {
                    Q1Correct = true;
                }
                else
                {
                    Q1Correct = false;
                }
                break;
            case 2:
                if (Q1Picked[1])
                {
                    Q1Correct = true;
                }
                else
                {
                    Q1Correct = false;
                }
                break;
        }
    }

    void Q2TestCheck()
    {
        switch (Q2Choice)
        {
            case 0:
                if (Q2Picked[2])
                {
                    Q2Correct = true;
                }
                else
                {
                    Q2Correct = false;
                }
                break;
            case 1:
                if (Q2Picked[0])
                {
                    Q2Correct = true;
                }
                else
                {
                    Q2Correct = false;
                }
                break;
            case 2:
                if (Q2Picked[1])
                {
                    Q2Correct = true;
                }
                else
                {
                    Q2Correct = false;
                }
                break;
        }
    }

    void Q3TestCheck()
    {
        switch (Q3Choice)
        {
            case 0:
                if (Q3Picked[2])
                {
                    Q3Correct = true;
                }
                else
                {
                    Q3Correct = false;
                }
                break;
            case 1:
                if (Q3Picked[0])
                {
                    Q3Correct = true;
                }
                else
                {
                    Q3Correct = false;
                }
                break;
            case 2:
                if (Q3Picked[1])
                {
                    Q3Correct = true;
                }
                else
                {
                    Q3Correct = false;
                }
                break;
        }
    }

    void Q4TestCheck()
    {
        switch (Q4Choice)
        {
            case 0:
                if (Q4Picked[2])
                {
                    Q4Correct = true;
                }
                else
                {
                    Q4Correct = false;
                }
                break;
            case 1:
                if (Q4Picked[0])
                {
                    Q4Correct = true;
                }
                else
                {
                    Q4Correct = false;
                }
                break;
            case 2:
                if (Q4Picked[1])
                {
                    Q4Correct = true;
                }
                else
                {
                    Q4Correct = false;
                }
                break;
        }
    }

    public void Q1Select()
    {
		Q1Picked = falseList;

        if (EventSystem.current.currentSelectedGameObject.CompareTag("Answer 1"))
        {
            Q1Picked[0] = true;
        }
        else if (EventSystem.current.currentSelectedGameObject.CompareTag("Answer 2"))
        {
            Q1Picked[1] = true;
        }
        else if (EventSystem.current.currentSelectedGameObject.CompareTag("Answer 3"))
        {
            Q1Picked[2] = true;
        }
        else if (EventSystem.current.currentSelectedGameObject.CompareTag("Answer 4"))
        {
            Q1Picked[3] = true;
        }
    }

    public void Q2Select()
    {
		Q2Picked = falseList;

		if (EventSystem.current.currentSelectedGameObject.CompareTag("Answer 1"))
        {
            Q2Picked[0] = true;
        }
        else if (EventSystem.current.currentSelectedGameObject.CompareTag("Answer 2"))
        {
            Q2Picked[1] = true;
        }
        else if (EventSystem.current.currentSelectedGameObject.CompareTag("Answer 3"))
        {
            Q2Picked[2] = true;
        }
        else if (EventSystem.current.currentSelectedGameObject.CompareTag("Answer 4"))
        {
            Q2Picked[3] = true;
        }
    }

    public void Q3Select()
    {
		Q3Picked = falseList;

		if (EventSystem.current.currentSelectedGameObject.CompareTag("Answer 1"))
        {
            Q3Picked[0] = true;
        }
        else if (EventSystem.current.currentSelectedGameObject.CompareTag("Answer 2"))
        {
            Q3Picked[1] = true;
        }
        else if (EventSystem.current.currentSelectedGameObject.CompareTag("Answer 3"))
        {
            Q3Picked[2] = true;
        }
        else if (EventSystem.current.currentSelectedGameObject.CompareTag("Answer 4"))
        {
            Q3Picked[3] = true;
        }
    }

    public void Q4Select()
    {
		Q4Picked = falseList;

		if (EventSystem.current.currentSelectedGameObject.CompareTag("Answer 1"))
        {
            Q4Picked[0] = true;
        }
        else if (EventSystem.current.currentSelectedGameObject.CompareTag("Answer 2"))
        {
            Q4Picked[1] = true;
        }
        else if (EventSystem.current.currentSelectedGameObject.CompareTag("Answer 3"))
        {
            Q4Picked[2] = true;
        }
        else if (EventSystem.current.currentSelectedGameObject.CompareTag("Answer 4"))
        {
            Q4Picked[3] = true;
        }
    }
}
