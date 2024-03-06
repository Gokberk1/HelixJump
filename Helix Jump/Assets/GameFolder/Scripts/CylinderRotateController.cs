using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotateController : MonoBehaviour
{
    [SerializeField] float _rotateSpeed;
    private float _moveX;

    private void Update()
    {
        _moveX = Input.GetAxis("Mouse X");

        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0, _moveX * _rotateSpeed * Time.deltaTime, 0f);
        }
    }
}
