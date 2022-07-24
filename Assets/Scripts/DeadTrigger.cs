using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
        Debug.Log("You Lost!");
       // GameObject.Find("GameManager").GetComponent<GameManager>().YouLost();
    }
}
