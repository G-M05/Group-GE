using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public EnemyAi hit;
    public playerManager currenthealth;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        hit = GetComponent<EnemyAi>();
        currenthealth = GameObject.FindGameObjectWithTag("Player").GetComponent<playerManager>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        //checking to see 
        if(collision.gameObject.tag == "Player")
        {
            currenthealth.TakeDamage(damage);
            hit.canFollowPlayer = false;
        }
        
    }
}
