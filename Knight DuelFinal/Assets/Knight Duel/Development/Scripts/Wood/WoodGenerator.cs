using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodGenerator : MonoBehaviour
{
    [SerializeField] GameObject wood;
    private Vector3 randomSpawn;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            randomSpawn = transform.position + Random.onUnitSphere * 15;
            randomSpawn.z = 0;
            Instantiate(wood, randomSpawn, transform.rotation);

            yield return new WaitForSeconds(1f);
        }
        
    }
}
