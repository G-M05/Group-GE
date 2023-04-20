using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public playerManager currenthealth;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        
        currenthealth = GameObject.FindGameObjectWithTag("Player").GetComponent<playerManager>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        //checking to see 
        if(collision.gameObject.tag == "Player")
        {
            currenthealth.TakeDamage(damage);
        }
    }
}
