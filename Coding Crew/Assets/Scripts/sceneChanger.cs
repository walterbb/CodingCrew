using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{

    public Animator anim;

    public void ClassScene()
    {
        StartCoroutine(ClassLoad());
    }


    IEnumerator ClassLoad()
    {
        PlayerPrefs.SetInt("Day", 1);
        anim.SetBool("play", true);
        yield return new WaitForSeconds(1);
        anim.SetBool("play", false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
