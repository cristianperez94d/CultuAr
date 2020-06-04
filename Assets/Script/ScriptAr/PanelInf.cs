using UnityEngine;
using System.Collections;

public class PanelInf : MonoBehaviour {
    public GameObject[] panelInf;
    private string barraBotones = "PanelBotones";
    private string panelTitulo = "Titulo";
    private int posTitulo = -1;
    private string []nombrePanel;
    bool estado = false;
    // Use this for initialization
    void Start() {
        nombrePanel = new string[panelInf.Length];

        for (int i = 0; i < panelInf.Length; i++)
        {
            if (panelInf[i].name.Equals(barraBotones))
            {
                panelInf[i].SetActive(true);
            }
            else {
                panelInf[i].SetActive(false);
            }
            nombrePanel[i] = panelInf[i].name;
        }
    }

    // Update is called once per frame
    void Update() {

    }
    private void Activar(string panel){
        for (int i = 0; i<nombrePanel.Length;i++)
        {
            if (nombrePanel[i].Equals(panel))
            {
                panelInf[i].SetActive(true);
            }
        }
    }
    private void Desactivar(string panel)
    {
        for (int i = 0; i < nombrePanel.Length; i++)
        {
            if (nombrePanel[i].Equals(panel))
            {
                panelInf[i].SetActive(false);
            }

        }
    }

    public void estadoPersonaje(bool estado)
    {
        this.estado = estado;
        ActivarPanel(barraBotones);
    }
    public void ActivarPanel(string panel)
    {
        if (estado)
        {
            if (panel.Equals(barraBotones))
            {
                Debug.Log("SoloActiva Barra");
                Desactivarpanel("");
                Desactivar(panelTitulo);
                Activar(panel);
                //Desactivar(panelTitulo);
                
            }
            //Debug.Log("ActivarPaneles");

            else
            {
                Desactivarpanel(panel);
                Debug.Log("ActivarTitulo");
                Activar(panelTitulo);
                switch (panel)
                {
                    case "personaje":
                        //Debug.Log("Activiar Panel personaje");
                        Activar(panel);
                        break;
                    case "vestuario":
                        //Debug.Log("Activiar Panel vestuario");
                        Activar(panel);
                        break;
                    case "instrumento":
                        //Debug.Log("Activiar Panel instrumento");
                        Activar(panel);
                        break;
                    default:
                        Debug.Log("Ningun panel");
                        break;
                }
            }
        }
        else
        {
            Debug.Log("DesactivarPaneles");
            Desactivarpanel("");
        }

    }
    private void Desactivarpanel(string panel)
    {
        for (int i = 0;i<panelInf.Length; i++)
        {
            if (!(panelInf[i].name.Equals(panel)))
            {
                if (!(panelInf[i].name.Equals(barraBotones)))
                {
                    if (!(panelInf[i].name.Equals(panelTitulo))) {

                        //Debug.Log("Desactivar Panel" + panelInf[i].name);
                        panelInf[i].SetActive(false);
                    }
                }
            }
        }
    }


}
