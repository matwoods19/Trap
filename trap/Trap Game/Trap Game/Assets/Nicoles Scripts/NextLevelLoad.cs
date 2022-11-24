using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelLoad : MonoBehaviour {

    public int level;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(level);
        DontDestroyOnLoad(player);
    }

}
