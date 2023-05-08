using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDestroy : MonoBehaviour
{
    public float bulletSpeed;
    private PlayerMovement player;
    public Rigidbody2D rb;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
       if (player.facingRight)
        {
            rb.AddForce(Vector2.right * bulletSpeed, ForceMode2D.Impulse);
        }
       if (!player.facingRight)
        {
            rb.AddForce(Vector2.left * bulletSpeed, ForceMode2D.Impulse);
        }
        
        
    }

    //checks to see if bullet colides with something if it does the bullet gets destroyed
    private void OnTriggerEnter2D(Collider2D collision)
    {

        // Enemies to tak damage
        if (collision.gameObject.TryGetComponent<EnemyAi>(out EnemyAi enemyComponent))
        {

            enemyComponent.TakeDamage(1);

        }
        else if(collision.gameObject.TryGetComponent<BossBehavior>(out BossBehavior enemyComponent))
        {

        }
        Destroy(gameObject); //destry bullet in all cases
    }
}
