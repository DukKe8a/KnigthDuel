using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifes : MonoBehaviour
{
    public GameObject[] hearts;
    private int lifes;

    private void Start()
    {
        lifes = hearts.Length;
    }

    private void Update()
    {
        if (lifes < 1)
        {
            Destroy(hearts[0].gameObject);
            Destroy(gameObject);
            NextLevel.Death++;
        }
        else if (lifes < 2)
        {
            Destroy(hearts[1].gameObject);
        }
        else if (lifes < 3)
        {
            Destroy(hearts[2].gameObject);
        }
    }

    public void Hit()
    {
        lifes--;
    }
}
