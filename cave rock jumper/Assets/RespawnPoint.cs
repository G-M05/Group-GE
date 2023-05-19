using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    private Vector3 respawnPoint;

    private void Start() {
        respawnPoint = GameObject.FindGameObjectWithTag("Respawn").GetComponent<Transform>().position;
    }

   private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "FallDetector")
        {
            transform.position = respawnPoint;
        }
        else if(collision.tag == "Respawn")
        {
            respawnPoint = transform.position;
        }
    }
}
