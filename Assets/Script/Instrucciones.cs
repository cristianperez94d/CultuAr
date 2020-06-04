using UnityEngine;
using System.Collections;

public class Instrucciones : MonoBehaviour {
    public GameObject panelContenido;
    private int posicion=0;
    int numHijos=0;
    // Use this for initialization
    void Start() {
        numHijos = panelContenido.transform.childCount;
        activarHijo(-1);
    }

    // Update is called once per frame
    void Update() {

    }
    //Desactivamos los hijos a escepcion de la poscicion que enviamos la cual debe activarse
    public void activarHijo(int boton)
    {
        if (boton == 0)//0 boton iquierdo
        {
            posicion -= 1;
            if (posicion < 0)
            {
                posicion = 0;
            }
            else
            {
                desactivarHijos(posicion);
            }
        }
        else if(boton ==1)//1 boton derecho
        {
            posicion += 1;
            if (posicion < numHijos)
            {
                desactivarHijos(posicion);
            }
            else
            {
                posicion -= 1;
            }
        }
        else //si es -1 activamos el primero
        {
            desactivarHijos(posicion);
        }

    }

    void desactivarHijos(int posicion)
    {
        int pos = 0;
        foreach (Transform hijo in panelContenido.transform)
        {
            if (pos == posicion)
            {
                hijo.gameObject.SetActive(true);
            }
            else
            {
                hijo.gameObject.SetActive(false);
            }
            pos++;
            //Debug.Log("Nombre: " + hijo.gameObject.name);
            //DesactivarHijos(hijo.gameObject , estado);
        }
    }
    
}
