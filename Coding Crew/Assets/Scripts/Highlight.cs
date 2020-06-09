using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highlight : MonoBehaviour
{
	public Camera cam;

    void Start()
    {

    }

    void Update()
    {
		RaycastHit hit;

		if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 20))
		{
			if(hit.transform.tag == transform.tag)
			{
				transform.GetChild(0).gameObject.SetActive(true);
			}
			else
			{
				transform.GetChild(0).gameObject.SetActive(false);
			}
		}
	}
}
