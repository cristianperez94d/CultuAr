using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Control : MonoBehaviour {
    public GameObject panelInstrucciones;
    public GameObject panelPrincipal;
    public GameObject panelAutores;
    public GameObject panelBarra;
    public Txt_C_intrucciones txt_C_Intrucciones;
    public Texto texto;

	// Use this for initialization
	void Start () {
        DesactivarPanel(panelAutores);
        DesactivarPanel(panelInstrucciones);
        ActivarPanel(panelPrincipal);
        DesactivarPanel(panelBarra);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {

            Debug.Log("Sale de la aplicacion");
            Application.Quit();
        }
    }

    //metodo para identificar que boton se presiono
    public void BotonPresionado(string nombre)
    {
        if (nombre.Equals("BtnIntrucciones")) {
            Debug.Log("btnIntrucciones activado");
            ActivarPanel(panelInstrucciones);
            DesactivarPanel(panelPrincipal);
            DesactivarPanel(panelAutores);
        }
        else if(nombre.Equals("BtnAR")){
            ActivarPanel(panelBarra);
            DesactivarPanel(panelAutores);
            DesactivarPanel(panelInstrucciones);
            //DesactivarPanel(panelPrincipal);
        }
        else if (nombre.Equals("BtnAutor"))
        {
            Debug.Log("btnAutor activado");
            ActivarPanel(panelAutores);
            DesactivarPanel(panelPrincipal);
            DesactivarPanel(panelInstrucciones);
            
        }
        else if (nombre.Equals("BtnAtras"))
        {
            Debug.Log("btnAtras activado");
            ActivarPanel(panelPrincipal);
            DesactivarPanel(panelInstrucciones);
            DesactivarPanel(panelAutores);
        }
        else if (nombre.Equals("BtnCastellano"))
        {
            Debug.Log("Cambia a castellano");
            txt_C_Intrucciones.CambiarIdioma(texto.getCastellano());
        }
        else if (nombre.Equals("BtnKamentsa"))
        {
            Debug.Log("Cambia a kamentsa");
            txt_C_Intrucciones.CambiarIdioma(texto.getKamentsa());
        }
    }
    void ActivarPanel(GameObject obj)
    {
        obj.SetActive(true);
    }
    void DesactivarPanel(GameObject obj)
    {
        obj.SetActive(false);
    }
}
