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
            }
        }
        else
        {
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 20))
            {
                Renderer posterRenderer = hit.transform.GetComponent<Renderer>();
                foreach (GameObject pS in Posters)
                {
                    posterRenderer.material.EnableKeyword("_EMISSION");
                    if(hit.transform.tag == pS.transform.tag)
                    {
                        posterRenderer.material.SetColor("_EmissionColor", posterRenderer.material.color * .15f);
                    }
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            foreach(GameObject p in Posters)
            {
                p.SetActive(false);
                posterOpen = false;
            }
        }
    }
}
