using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }

    // Update is called once per frame
    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
