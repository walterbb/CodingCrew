using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public bool TestActive;
    public GameObject pointer;
    public Camera mainCam;

    // Start is called before the first frame update
    void Start()
    {
        pointer.SetActive(false);
        mainCam.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
        mainCam.transform.position = new Vector3(-3.2f, 1.48f, -2f);
        mainCam.fieldOfView = 75f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            TestActive = true;
            TestTime();
        }
        else if (Input.GetKeyDown(KeyCode.Tab))
        {
            TestActive = false;
            TestOff();
        }
    }

    public void TestOff()
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
        mainCam.transform.rotation = Quaternion.Euler(new Vector3(61.66f,0f,0f));
        mainCam.transform.position = new Vector3(-3.2f, 1.7f, -1.85f);
        mainCam.fieldOfView = 31f;

        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
}
