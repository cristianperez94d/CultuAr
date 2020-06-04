using UnityEngine;
using System.Collections;

public class PanelAutor : MonoBehaviour {

    public GameObject[] elementos;
    string[] nombreElemento;
    string temp = "";
	// Use this for initialization
	void Start () {
        nombreElemento = new string[elementos.Length];
        for (int i = 0; i<elementos.Length; i++)
        {
            if (i == 0)
            {
                elementos[i].SetActive(true);
                temp = elementos[i].name;
            }
            else
            {
                elementos[i].SetActive(false);
            }
            nombreElemento[i] = elementos[i].name;
            Debug.Log("Nombres:"+elementos[i].name);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void ActivarElementos(string nombre)
    {
        if (!temp.Equals(nombre)) {
            for (int i = 0; i < elementos.Length; i++)
            {
                if (nombreElemento[i].Equals(nombre))
                {
                    if (elementos[i].activeSelf)
                    {
                        elementos[i].SetActive(false);
                    }
                    else
                    {
                        elementos[i].SetActive(true);
                    }
                    desactivar(i);
                    temp = nombre;
                }
            }
        }
    }

    private void desactivar(int pos)
    {
        for (int i = 0; i < elementos.Length; i++)
        {
            if (i != pos)
            {
                elementos[i].SetActive(false);
            }
        }
    }
}
