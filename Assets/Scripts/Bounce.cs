using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.up * 5;
    }
}
