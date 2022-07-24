using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [SerializeField]
    private float rotateMultiplier;
    private void Update()
    {
        if (Time.timeScale>0)
        {
            gameObject.transform.Rotate(Vector3.up, Input.GetAxis("Horizontal")*rotateMultiplier);
        }
    }
}
