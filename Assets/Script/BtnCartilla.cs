using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class BtnCartilla : MonoBehaviour, IPointerClickHandler
{
    public string urlCartilla = "https://drive.google.com/file/d/1sOXoXF2Sn6ThCLkMzT00Zg2n0-4FkKPZ/view?usp=sharing";
    public void OnPointerClick(PointerEventData eventData)
    {
        Application.OpenURL(urlCartilla);
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
