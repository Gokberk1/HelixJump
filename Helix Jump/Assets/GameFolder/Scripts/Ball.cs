using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody _rb;
    [SerializeField] float _jumpForce;
    [SerializeField] GameObject _splashPrefab;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        _rb.AddForce(Vector3.up * _jumpForce);

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;

        GameObject splash = Instantiate(_splashPrefab, transform.position + new Vector3(0, -transform.localScale.y/2.05f, 0), transform.rotation);
        splash.transform.SetParent(collision.gameObject.transform);

       
        if (materialName == "UnsafePlatformMat (Instance)")
        {
            GameManager.Instance.StopGame();
        }
        else if(materialName == "LastRingMat (Instance)")
        {
            GameManager.Instance.StopGame();
        }
    }
}
