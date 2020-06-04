using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BtnFlechaIntrucciones : MonoBehaviour, IPointerClickHandler
{
    public Instrucciones instrucciones;
    public bool flechaDer;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (flechaDer)
        {
            Debug.Log("Derecha");
            instrucciones.activarHijo(1);
        }
        else
        {
            Debug.Log("izquierda");
            instrucciones.activarHijo(0);
        }
        
    }

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	    
	}

}
