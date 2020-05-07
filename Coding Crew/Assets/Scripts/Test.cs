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
        pointer.SetActive(false);
        mainCam.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
        mainCam.fieldOfView = 75f;
    }

    public void TestTime()
    {
        pointer.SetActive(false);
        mainCam.transform.rotation = Quaternion.Euler(new Vector3(42.7f,0f,0f));
        mainCam.fieldOfView = 31f;
    }
}
