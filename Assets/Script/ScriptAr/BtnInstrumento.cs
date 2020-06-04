using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class BtnInstrumento : MonoBehaviour, IPointerClickHandler
{
    public PanelInf panelInf;
    public static bool tempInstrumento=false;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (tempInstrumento)
        {
            panelInf.estadoPersonaje(tempInstrumento);
            tempInstrumento = false;
        }
        else
        {
            panelInf.ActivarPanel("instrumento");
            tempInstrumento = true;
            BtnVestuario.tempVestuarioVestuario = false;
            BtnPersonaje.tempPersonaje = false;
        }
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
