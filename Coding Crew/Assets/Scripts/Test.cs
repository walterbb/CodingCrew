using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;



public class Test : MonoBehaviour
{

    public bool TestActive;
    public GameObject pointer;
    public Camera mainCam;

    public posterVeiw posVeiw;

    public Slider timerSlider;
    public int waitTime;
    public int timeForTest;
    private float timeTillTest;
    public Text timeTillText;

    bool pauseTest;

    public Button TurnIn;

    // Start is called before the first frame update
    void Start()
    {
        pointer.SetActive(true);
        mainCam.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
        mainCam.transform.position = new Vector3(-3.2f, 1.48f, -2f);
        mainCam.fieldOfView = 75f;

        timerSlider.maxValue = waitTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(!TestActive)
        {
            BeforeTest();
        }
        else if (TestActive)
        {
            AfterTest();
        }
    }

    public void TestOver()
    {
        SceneManager.LoadScene("GradeCheck");
    }

    void AfterTest()
    {
        timeTillTest += Time.deltaTime;

        timeTillTest = Mathf.Clamp(timeTillTest, 0f, waitTime);

        timerSlider.value = timeForTest - timeTillTest;

        if(timerSlider.value == 0)
        {
            TestOver();
        }

        if(Input.GetKeyDown(KeyCode.T))
        {
            if(pauseTest)
            {
                pauseTest = false;
                TestTime();
            }
            else if (!pauseTest)
            {
                pauseTest = true;
                TestPause();
            }
        }
    }

    void BeforeTest()
    {
        timeTillTest += Time.deltaTime;

        timeTillTest = Mathf.Clamp(timeTillTest, 0f, waitTime);

        timerSlider.value = waitTime - timeTillTest;

        if (timeTillTest == waitTime && TestActive == false)
        {
            TestActive = true;
            timeTillText.text = "TEST OVER IN";
            timerSlider.value = timeForTest;
            timerSlider.maxValue = timeForTest;
            timeTillTest = 0;
            TestTime();
        }
    }

    public void TestPause()
    {
        pointer.SetActive(true);
        mainCam.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
        mainCam.transform.position = new Vector3(-3.2f, 1.48f, -2f);
        mainCam.fieldOfView = 75f;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void TestTime()
    {
        pointer.SetActive(false);
        mainCam.transform.rotation = Quaternion.Euler(new Vector3(90f,0f,0f));
        mainCam.transform.position = new Vector3(-3.2f, 1.87f, -1.43f);
        mainCam.fieldOfView = 31f;

        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
}
