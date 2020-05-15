using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextDay : MonoBehaviour
{
    public static NextDay nextDay;

    public int day;

    public void Start()
    {
        nextDay = this;
        day = 1;
    }

    // Start is called before the first frame update
    public void SceneSwitch()
    {
        day++;

        switch (day)
        {
            case 2:
                SceneManager.LoadScene("LClassroom2");
                break;
            case 3:
                SceneManager.LoadScene("LClassroom3");
                break;
        }
    }
}
