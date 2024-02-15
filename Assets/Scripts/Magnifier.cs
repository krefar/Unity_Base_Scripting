using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnifier : MonoBehaviour
{
    [SerializeField] private Vector3 _maxSize;
    [SerializeField] private Vector3 _minSize;
    [SerializeField] private float _speed;

    private bool IsIncrease { get; set; }

    private void Update()
    {
        this.EnsureIncrease();

        var scaleTo = IsIncrease ? (1 + _speed * Time.deltaTime) * transform.localScale : (1 - _speed * Time.deltaTime) * transform.localScale;
        transform.localScale += scaleTo - transform.localScale;
    }

    private void EnsureIncrease()
    {
        if (transform.localScale == _minSize || transform.localScale.x < _minSize.x || transform.localScale.y < _minSize.y || transform.localScale.z < _minSize.z)
        {
            IsIncrease = true;
        }
        else if (transform.localScale == _maxSize || transform.localScale.x > _maxSize.x || transform.localScale.y > _maxSize.y || transform.localScale.z > _maxSize.z)
        {
            IsIncrease = false;
        }
    }
}
