using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlAr : MonoBehaviour {
    public GameObject btnAtras;
    GameObject Matachin,Banderero,Bata,SanJuan,SanJuan2,Niño,Niña,Taita,Saraguay,Saraguay2;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("SAle de la aplicacion");
            SceneManager.LoadScene("AR");
        }
    }


}
