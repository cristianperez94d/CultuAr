using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnimarPersonaje : MonoBehaviour {

    Animator anim;
    AudioSource audio;
    public AudioSource audio2;
    public GameObject PanelPersonaje;
    public Animator AnimInstrumento;
    public Animator AnimObjeto;
    public PanelInf panelInf;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();//Primer audio a sonar
        PanelPersonaje.SetActive(false);
    }

    // Update is called once per frame

    void Update()
    {
       
    }
    public void Animacion(bool personaje)
    {
        if (anim != null)
        {
            Debug.Log("Animator inicializado");
            Audio(personaje);
            anim.SetBool("Baila", personaje);
            if (AnimInstrumento != null) {
                AnimInstrumento.SetBool("Animar", personaje);
                if (AnimObjeto != null)
                {
                    AnimObjeto.SetBool("Animar",personaje);
                }
            }
        }
    }
    private void Audio(bool baila)
    {
        
        Debug.Log("Audio");
        //play
        if (baila)
        {
            Debug.Log("Audio Play");
            audio.Play();
            PanelPersonaje.SetActive(true);
            if (audio.isPlaying)
            {
                audio2.PlayDelayed(audio.clip.length-0.5f);
            }
            else
            {
                Debug.Log("Audio Apagado");
            }
            panelInf.estadoPersonaje(true);
        }
        //stop
        else
        {
            PanelPersonaje.SetActive(false);
            Debug.Log("Audio Stop");
            audio.Stop();
            audio2.Stop();

            panelInf.estadoPersonaje(false);
        }
    }
}
