using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Axis _axis;

    private void Update()
    {
        if (_axis.HasFlag(Axis.X))
        {
            transform.RotateAround(transform.position, transform.right, _speed * Time.deltaTime);
        }

        if (_axis.HasFlag(Axis.Y))
        {
            transform.RotateAround(transform.position, transform.up, _speed * Time.deltaTime);
        }

        if (_axis.HasFlag(Axis.Z))
        {
            transform.RotateAround(transform.position, transform.forward, _speed * Time.deltaTime);
        }
    }
}
