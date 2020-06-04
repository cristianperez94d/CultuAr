using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class UrlVideo : MonoBehaviour, IPointerClickHandler
{
    public string urlVideo = "https://youtu.be/IovyZf-E2bU";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void verVideo()
    {
        Application.OpenURL(urlVideo);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        verVideo();
    }
}
