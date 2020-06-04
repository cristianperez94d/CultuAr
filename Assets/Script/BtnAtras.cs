using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class BtnAtras : MonoBehaviour, IPointerClickHandler
{
    public Control control;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("ClickBotonAtras");
        control.BotonPresionado(this.name);
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
