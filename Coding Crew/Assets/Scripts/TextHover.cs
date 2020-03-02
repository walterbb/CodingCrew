using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHover : MonoBehaviour
{
    public Text text;

    public void OnMouseEnter()
    {
        text.color = Color.red;
    }

    public void OnMouseExit()
    {
        text.color = Color.white; 
    }
}
