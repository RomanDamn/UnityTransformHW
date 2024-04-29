using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverForward : MonoBehaviour
{
    private Vector3 _direction;

    [SerializeField] private float _speed;

    private void Start()
    {
        _direction = transform.forward;
    }

    private void Update()
    {
        Vector3 move = _direction * _speed;
        transform.Translate(move, Space.World);
    }
}
