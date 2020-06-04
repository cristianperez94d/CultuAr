using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class BotonBarra : MonoBehaviour, IPointerClickHandler
{
    public PanelAutor ScriptPanelAutor;
    public Object panel;
    public void OnPointerClick(PointerEventData eventData)
    {
        ScriptPanelAutor.ActivarElementos(panel.name);
        Debug.Log("Nombre:"+ panel.name);
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
