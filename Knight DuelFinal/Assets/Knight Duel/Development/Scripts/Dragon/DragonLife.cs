using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonLife : MonoBehaviour
{
    public GameObject[] hearts;
    private int lifesD;

    private void Start()
    {
        lifesD = hearts.Length;
    }

    private void Update()
    {
        if (lifesD < 1)
        {
            Destroy(hearts[0].gameObject);
            Destroy(gameObject);
            PlayerManager.Instance.nextLevel();
        }
        else if (lifesD < 2)
        {
            Destroy(hearts[1].gameObject);
        }
        else if (lifesD < 3)
        {
            Destroy(hearts[2].gameObject);
        }
        else if (lifesD < 4)
        {
            Destroy(hearts[3].gameObject);
        }
        else if (lifesD < 5)
        {
            Destroy(hearts[4].gameObject);
        }
        else if (lifesD < 6)
        {
            Destroy(hearts[5].gameObject);
        }
        else if (lifesD < 7)
        {
            Destroy(hearts[6].gameObject);
        }
        else if (lifesD < 8)
        {
            Destroy(hearts[7].gameObject);
        }
        else if (lifesD < 9)
        {
            Destroy(hearts[8].gameObject);
        }
    }

    public void HitD()
    {
        lifesD--;
    }
}