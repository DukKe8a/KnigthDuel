using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodMove : MonoBehaviour
{
    private Rigidbody2D rigidbody_;
    public GameObject sfx;

    void Start()
    {
        rigidbody_ = GetComponent<Rigidbody2D>();
        rigidbody_.angularVelocity = Random.Range(-360, 360);
        rigidbody_.velocity = new Vector2(0,  Random.Range(-8, -5));
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeathLimit"))
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("Player"))
        {
            if (sfx != null)
            {
                Instantiate(sfx, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}
