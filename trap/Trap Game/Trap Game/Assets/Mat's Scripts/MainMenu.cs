using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	public void start ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
	}
	
	public void Quit()
    {
        Application.Quit();
    }
}
