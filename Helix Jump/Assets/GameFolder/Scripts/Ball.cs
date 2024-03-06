using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody _rb;
    private Vector3 _startPos;
    [SerializeField] float _jumpForce;
    [SerializeField] GameObject _splashPrefab;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _startPos = gameObject.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        _rb.AddForce(Vector3.up * _jumpForce);

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;

        GameObject splash = Instantiate(_splashPrefab, transform.position + new Vector3(0, -transform.localScale.y/2.05f, 0), transform.rotation);
        splash.transform.SetParent(collision.gameObject.transform);

        if (materialName == "SafePlatformMat (Instance)")
        {
            //puan alacak
        }
        else if (materialName == "UnsafePlatformMat (Instance)")
        {
            Debug.Log("öldü");
        }
        else if(materialName == "LastRingMat (Instance)")
        {
            //yeni lvl
        }
    }
}
