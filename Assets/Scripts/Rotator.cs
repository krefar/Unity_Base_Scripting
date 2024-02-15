using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 direction;

    private void Update()
    {
        transform.RotateAround(transform.position, direction, _speed * Time.deltaTime);
    }
}
