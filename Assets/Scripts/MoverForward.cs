using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverForward : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _direction;

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
