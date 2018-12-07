using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [Tooltip("Tiempo inicial en segundos")]
    public int tiempoInicial;
    [Tooltip("Escala del tiempo del reloj")]
    [Range(-10.0f, 10.0f)]
    public float escalaTiempo = 1;

    private Text myText;
    private float tiempoDelFrameConTimeScale = 0f;
    private float timeInSecondsToShow = 0f;
    private float escalaPausada, escalaInicial;
    private bool isPaused = false;
   
	
	void Start ()
    {
        escalaInicial = escalaTiempo;
        myText = GetComponent<Text>();
        timeInSecondsToShow = tiempoInicial;

        Actualizar(tiempoInicial);
	}
	
	
	void Update ()
    {
        tiempoDelFrameConTimeScale = Time.deltaTime * escalaTiempo;
        timeInSecondsToShow += tiempoDelFrameConTimeScale;
        Actualizar(timeInSecondsToShow);

    }

    public void Actualizar(float tiempoSegundos)
    {
        int minutos = 0;
        int segundos = 0;
        string textoReloj;

        if (tiempoSegundos < 0) tiempoSegundos = 0;

        minutos = (int)tiempoSegundos / 60;
        segundos = (int)tiempoSegundos % 60;

        textoReloj = minutos.ToString("00") + ":" + segundos.ToString("00");

        myText.text = textoReloj;

        if (segundos == 5)
        {
            SceneManager.LoadScene("2");
        }
    }
}
