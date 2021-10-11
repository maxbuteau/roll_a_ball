using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {

        
    }
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")){
            player.GetComponent<PlayerController>().SpeedUp();
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")){
            player.GetComponent<PlayerController>().SlowDown();
        }
    }
}
