using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class BtnCastellano : MonoBehaviour, IPointerClickHandler
{
    public Control control;
    public void OnPointerClick(PointerEventData eventData)
    {
        control.BotonPresionado(this.name);
    }

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
