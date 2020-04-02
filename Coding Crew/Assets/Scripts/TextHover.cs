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
         text.fontSize = text.fontSize + 10;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.fontSize = text.fontSize - 10;
    }

    public void ButtonClicked()
    {
        text.fontSize = text.fontSize - 10;
    }
}
