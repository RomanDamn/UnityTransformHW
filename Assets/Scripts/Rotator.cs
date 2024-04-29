using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _rotationCenter;

    private void Update()
    {
        transform.RotateAround(_rotationCenter.position, Vector3.up, _speed);
    }
}
