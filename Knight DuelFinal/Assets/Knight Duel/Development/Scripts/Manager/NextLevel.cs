using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public static float Death { get; set; } = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerManager.Instance.nextLevel();
        }
    }

    private void Update()
    {
        if (NextLevel.Death == 2)
        {
            PlayerManager.Instance.nextLevel();
        }
    }
}
