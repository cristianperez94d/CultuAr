using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Txt_C_intrucciones : MonoBehaviour {
    public Text txt_C_Instruciones;
    Scrollbar scrollbar;
	// Use this for initialization
    public void CambiarIdioma(string instrucciones)
    {
        txt_C_Instruciones.text=instrucciones;
    }
}
