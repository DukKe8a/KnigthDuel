using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutoriales : MonoBehaviour
{
    [SerializeField] int level;

    public void Play()
    {
        SceneManager.LoadScene(level);
    }
}
