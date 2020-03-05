using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TextHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text text;

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.color = new Color(0,1f,1f,.9f);
        text.fontSize = text.fontSize + 10;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.color = Color.white;
        text.fontSize = text.fontSize - 10;
    }

    public void ButtonClicked()
    {
        text.color = Color.white;
        text.fontSize = text.fontSize - 10;
    }
}
