using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _movementDirection;
    [SerializeField] private bool _isForward;

    private void Update()
    {
        if(_isForward)
        {
            _movementDirection = transform.forward;
        }

        Vector3 move = _movementDirection * _speed;
        transform.Translate(move, Space.World);
    }
}
