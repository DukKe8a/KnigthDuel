using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    [SerializeField] private float _speedMult = -5;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.velocity = new Vector2(1 * _speedMult, _rigidbody.velocity.y);
    }

    void Update()
    {
        if (transform.position.x > 380) 
        {
            _rigidbody.velocity = Vector3.zero;
        }
    }
}
