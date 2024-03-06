using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform _target;
    private Vector3 _offset;
    [SerializeField] float _smoothMoveSpeed;
    private void Awake()
    {
        _offset = transform.position - _target.position;
    }
    private void LateUpdate()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, _offset + _target.position, _smoothMoveSpeed);
        transform.position = newPos;
    }
}
