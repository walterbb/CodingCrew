using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class posterVeiw : MonoBehaviour
{

    public Camera cam;

    public List<GameObject> Posters;

    bool posterOpen;

    Animator anim;

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
                foreach (GameObject pS in Posters)
                {
                    if(hit.transform.tag == pS.transform.tag)
                    {   
                        anim = hit.transform.GetComponent<Animator>();
                        anim.SetBool("Poster_look", true);
                        StartCoroutine(PosterAnim());
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

    IEnumerator PosterAnim()
    {
        yield return new WaitForSeconds(1f);
        anim.SetBool("Poster_look", false);
    }
}
