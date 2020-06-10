using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinOrLose : MonoBehaviour
{
    public void Win()
    {
        SceneManager.LoadScene("WinScene");
    }

    public void Lose()
    {
        SceneManager.LoadScene("LoseScene");
    }

    public void toMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
