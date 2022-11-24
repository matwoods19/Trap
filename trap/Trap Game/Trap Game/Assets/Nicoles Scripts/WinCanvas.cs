using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinCanvas : MonoBehaviour {

    //public int sceneIndex;

    public void MainMenu() // If the player clicks this it goes to the main menu
    {
        //SceneManager.LoadScene(1, UnityEngine.SceneManagement.LoadSceneMode.Single);
        //SceneManager.UnloadSceneAsync(sceneIndex);

        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void quit() // If the player clicks this button the game quits
    {
        Application.Quit();
    }
}
