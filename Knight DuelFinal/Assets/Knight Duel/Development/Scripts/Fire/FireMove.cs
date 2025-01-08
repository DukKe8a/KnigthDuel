using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMove : MonoBehaviour
{
    Rigidbody2D rigidbody;
    [SerializeField] float speedMult = 3;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Move();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeathLimit2"))
        {
            DestroyEntity();
        }

        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerLifes>().Hit();
            DeleteEntity();
        }
    }

    public void Move()
    {
        rigidbody.velocity = Vector2.left * speedMult;
    }

    protected void DeleteEntity(params object[] args)
    {
        DestroyEntity();
    }
    protected void DestroyEntity()
    {
        Destroy(gameObject);
    }
}
