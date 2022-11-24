using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseCanvas : MonoBehaviour
{
    public GameObject PauseMenu;
    public Transform player;

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.Q))
        {
            Pause();
        }
    }

    public void Pause()
    {
        if (PauseMenu.gameObject.activeInHierarchy == false)
        {
            PauseMenu.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            PauseMenu.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void Menu()
    {

    }
}
