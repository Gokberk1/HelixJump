using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    [SerializeField] Transform _ball;

    private void Awake()
    {
    }
    private void Update()
    {
        if(transform.position.y >= _ball.position.y)
        {
            Destroy(gameObject);
            GameManager.Instance.AddScore(1);
        }
    }
}
