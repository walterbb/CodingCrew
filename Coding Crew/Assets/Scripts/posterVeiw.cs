using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class posterVeiw : MonoBehaviour
{

    public Camera cam;

    public List<GameObject> Posters;

    bool posterOpen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 20))
            {
                //Target target = hit.transform.GetComponent<Target>();
                Debug.Log(hit.transform.name);
                if (posterOpen != true)
                {
                    if (hit.transform.name == "Poster1")
                    {
                        Posters[0].SetActive(true);
                        posterOpen = true;
                    }
                    else if (hit.transform.name == "Poster 2")
                    {
                        Posters[1].SetActive(true);
                        posterOpen = true;
                    }
                    else if (hit.transform.name == "Poster 3")
                    {
                        Posters[2].SetActive(true);
                        posterOpen = true;
                    }
                    else if (hit.transform.name == "Poster 4")
                    {
                        Posters[3].SetActive(true);
                        posterOpen = true;
                    }
                    else if (hit.transform.name == "Poster 5")
                    {
                        Posters[4].SetActive(true);
                        posterOpen = true;
                    }
                }
            }
        }

        if(Input.GetKeyDown(KeyCode.Tab))
        {
            foreach(GameObject p in Posters)
            {
                p.SetActive(false);
                posterOpen = false;
            }
        }
    }
}
