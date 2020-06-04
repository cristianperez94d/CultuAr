using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class BtnAutores : MonoBehaviour, IPointerDownHandler, IPointerUpHandler,
    IPointerClickHandler
{
    public Control control;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("click boton autor"+ this.name);
        control.BotonPresionado(this.name);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void OnPointerUp(PointerEventData eventData)
    {
    }
    
}
