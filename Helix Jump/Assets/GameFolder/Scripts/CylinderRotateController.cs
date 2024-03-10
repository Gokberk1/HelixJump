using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotateController : MonoBehaviour
{
    [SerializeField] float _rotateSpeed;
    private float _moveX;
    private float _touchXDelta = 0;

    private void Update()
    {
        _moveX = Input.GetAxis("Mouse X");

        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0, _moveX * _rotateSpeed * Time.deltaTime, 0f);
        }

        SwipeCheck();
    }

    void SwipeCheck()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            _touchXDelta = Input.GetTouch(0).deltaPosition.x / Screen.width;
        }
        else
        {
            _touchXDelta = 0;
        }

        transform.Rotate(0, _touchXDelta * _rotateSpeed * Time.deltaTime, 0f);
    }
}
