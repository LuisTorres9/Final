using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interac : MonoBehaviour
{
    public static bool interact = false;
    public GameObject interPanel;

    void Update()
    {
        interPanel.SetActive(true);
        if (Input.GetKeyDown(KeyCode.M))
        {
            interPanel.SetActive(false);
        }

    }

    /*  pauseMenuUI.SetActive(false);
          Time.timeScale = 1f;
          GameIsPaused = false;*/
}
