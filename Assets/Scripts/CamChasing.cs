using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChasing : MonoBehaviour
{
    [SerializeField]
    GameObject ball;
    Vector3 offset = new Vector3(0, 2, -5);
    void Start()
    {
        transform.position = ball.transform.position+ offset;
    }
    void Update()
    {
        if (ball.transform.position.y<transform.position.y-2)
           transform.position=Vector3.Lerp(transform.position, ball.transform.position+offset, 1);
    }
}
