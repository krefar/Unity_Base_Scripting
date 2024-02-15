using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AxisMoving : MonoBehaviour
{
    [SerializeField] private Axis _moveDirection;
    [SerializeField] private bool _inverse;
    [SerializeField] private float _speed;

    private Vector3 _direction { get; set; }

    private void Update()
    {
        this.EnsureDirection();

        transform.position += _direction * _speed * Time.deltaTime;
    }

    private void EnsureDirection()
    {
        _direction = Vector3.zero;

        if (_moveDirection.HasFlag(Axis.X))
        {
            _direction += Vector3.right;
        }

        if (_moveDirection.HasFlag(Axis.Y))
        {
            _direction += Vector3.up;
        }

        if (_moveDirection.HasFlag(Axis.Z))
        {
            _direction += Vector3.forward;
        }

        if (_inverse)
        {
            _direction = -_direction;
        }
    }
}
