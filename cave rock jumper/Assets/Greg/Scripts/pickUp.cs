using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    // Start is called before the first frame update
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.CompareTag("Player"))
        {
            //creates a location and reference for our player manager script
            playerManager manager = collision.GetComponent<playerManager>();


            if (manager)
            {
                bool pickedUp = manager.PickupItem(gameObject);
                if(pickedUp)
                {
                    Destroy(gameObject);
                    
                }

            }
        }

    }




}
