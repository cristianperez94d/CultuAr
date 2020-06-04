using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EscenaAR : MonoBehaviour {
    public string escenaCargar;
    public float retraso;
    public void ActivarEscena()
    {
        Invoke("AR", retraso);
    }

    void cargarEscena()
    {
        SceneManager.LoadScene(escenaCargar);
    }

}
