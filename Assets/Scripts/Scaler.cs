using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _scaleDirection;
    void Update()
    {
        transform.localScale += _scaleDirection * _speed;
    }
}
