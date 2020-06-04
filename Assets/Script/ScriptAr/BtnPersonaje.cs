using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class BtnPersonaje : MonoBehaviour, IPointerClickHandler
{
    public PanelInf panelInf;
    public static bool tempPersonaje = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (tempPersonaje)
        {
            panelInf.estadoPersonaje(tempPersonaje);
            tempPersonaje = false;
        }
        else
        {
            panelInf.ActivarPanel("personaje");
            tempPersonaje = true;
            BtnInstrumento.tempInstrumento = false;
            BtnVestuario.tempVestuarioVestuario = false;
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
