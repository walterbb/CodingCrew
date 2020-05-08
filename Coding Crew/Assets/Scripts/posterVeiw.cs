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

    // Start is called before the first frame update
    void Start()
    {
        posterOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Input.GetKeyDown(KeyCode.Space))
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
