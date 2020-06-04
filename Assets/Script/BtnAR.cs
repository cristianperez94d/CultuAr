using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnAR : MonoBehaviour, IPointerClickHandler
{
    public Control control;
    public Image barraProgreso;
    public Text textoBarra;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Inicia AR");
        //SceneManager.LoadScene("AR");
        control.BotonPresionado(this.name);
        StartCoroutine(CargarEscenaAR());
        
    }
    IEnumerator CargarEscenaAR()
    {
        AsyncOperation result = SceneManager.LoadSceneAsync("AR");
        float progreso = 0;
        while (!result.isDone)
        {
            progreso = Mathf.Clamp01(result.progress);
            barraProgreso.fillAmount = progreso;
            textoBarra.text = "Cargando....";
            Debug.Log(progreso);
            yield return null;
        }
    }
    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
