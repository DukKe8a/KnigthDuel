using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpawner : MonoBehaviour
{
    [SerializeField] GameObject fire;
    [SerializeField] Vector2 randomFireRange;
    public GameObject sfx;

    private void Awake()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        while (true)
        {
            float randomMeteorRate = Random.Range(randomFireRange.x, randomFireRange.y);
            Instantiate(fire ,transform.position, Quaternion.identity);
            if (sfx != null)
            {
                Instantiate(sfx, transform.position, Quaternion.identity);
            }
            yield return new WaitForSeconds(randomMeteorRate);
        }
    }

}
