using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float xInput;
    private float yInput;
    private Animator _animator;
    [SerializeField] private int speedMult;
    [SerializeField] private string verticalInputAxisName;
    [SerializeField] private string horizontalInputAxisName;
    private int _speedMult = 10;
    private PlayerCollision _collision;
    private bool jumping = false;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _collision = GetComponent<PlayerCollision>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        xInput = Input.GetAxis(horizontalInputAxisName);
        yInput = Input.GetAxisRaw(verticalInputAxisName);
        _rigidbody.velocity = new Vector2(xInput * _speedMult, _rigidbody.velocity.y);

        if (yInput == 1 && _collision.onGround)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, 20f);
            _animator.SetBool("jumping", true);
            _animator.SetBool("walking", false);
            _animator.SetBool("idle", false);
        }
        else
        {
            _animator.SetBool("jumping", false);
            _animator.SetBool("idle", true);
        }
        if (xInput != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(xInput), 1, 1);
            _animator.SetBool("idle", false);
            _animator.SetBool("walking", true);
        }
        else
        {
            _animator.SetBool("walking", false);
            _animator.SetBool("idle", true);
        }
    }
}
