using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStart : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(5);
    }

    public void Exit()
    {
        Debug.Log("Salir....");
        Application.Quit();
    }
}
