using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class posterVeiw : MonoBehaviour
{

    public Camera cam;

    public List<GameObject> Posters;

    public bool posterOpen;

    public Test test;
    public WakeUpManager wakeUpM;

    // Start is called before the first frame update
    void Start()
    {
        posterOpen = false;
    }

    private void Update()
    {
        if(wakeUpM.wakeUp)
        {
            PosterLook();
        }
    }

    void PosterLook()
    {
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 20))
            {
                if (posterOpen != true)
                {
                    foreach(GameObject pS in Posters)
                    {
                        if (hit.transform.tag == pS.transform.tag)
                        {
                            pS.SetActive(true);
                            posterOpen = true;
                        }
                    }
                }
                else if (posterOpen == true)
                {
                    foreach (GameObject p in Posters)
                    {
                        p.SetActive(false);
                        posterOpen = false;
                    }
                }
            }
        }
        if (test.TestActive)
        {
            foreach (GameObject p in Posters)
            {
                p.SetActive(false);
                posterOpen = false;
            }
        }
    }
}
