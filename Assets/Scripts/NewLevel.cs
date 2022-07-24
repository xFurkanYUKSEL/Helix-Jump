using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLevel : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Congratulations!");
        GameObject.Find("GameManager").GetComponent<GameManager>().State = GameManager.GameState.LevelPassed;
    }
}
