using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManagerPrincipio : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CargaNivel(string nombreNivel)
    {
        SceneManager.LoadScene(nombreNivel); 
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game ... Exit...");
        Application.Quit();
    }
}
