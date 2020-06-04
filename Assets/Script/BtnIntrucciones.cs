using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class BtnIntrucciones : MonoBehaviour, IPointerDownHandler, IPointerUpHandler,
    IPointerEnterHandler, IPointerClickHandler
{
    public Control control;

    public void OnPointerClick(PointerEventData eventData)
    {
        control.BotonPresionado(this.name);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
       // Debug.Log("On pointer enter");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
    }
}
