using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    [SerializeField] Transform _ball;

   

    private void Update()
    {
        if(transform.position.y > _ball.position.y + 1)
        {
            Destroy(gameObject);
            GameManager.Instance.AddScore(1);
        }
    }

   
}
