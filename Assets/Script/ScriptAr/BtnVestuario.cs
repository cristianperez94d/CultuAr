using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class BtnVestuario : MonoBehaviour, IPointerClickHandler
{
    public PanelInf panelInf;
    public static bool tempVestuarioVestuario=false;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (tempVestuarioVestuario)
        {
            panelInf.estadoPersonaje(tempVestuarioVestuario);
            tempVestuarioVestuario = false;
        }
        else
        {
            panelInf.ActivarPanel("vestuario");
            tempVestuarioVestuario = true;
            BtnInstrumento.tempInstrumento = false;
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
