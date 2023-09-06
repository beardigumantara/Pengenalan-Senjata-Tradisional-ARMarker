using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    public void StartGame() 
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void CreditsContent() 
    {
        SceneManager.LoadScene("Credits");
    }
}
