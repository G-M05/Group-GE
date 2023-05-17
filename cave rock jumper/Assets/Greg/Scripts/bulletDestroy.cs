using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class bulletDestroy : MonoBehaviour
{
    public float bulletSpeed;
    private void FixedUpdate()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(gameObject.transform.forward * bulletSpeed, 0);
    }

    //checks to see if bullet colides with something if it does the bullet gets destroyed
    private void OnTriggerEnter2D(Collider2D collision)
    {

        // Enemies to take damage
        if (collision.gameObject.TryGetComponent<EnemyAi>(out EnemyAi enemyComponent))
        {

            enemyComponent.TakeDamage(1);

        }
        else if (collision.gameObject.TryGetComponent<BossBehavior>(out BossBehavior bossComponent))
        {
            bossComponent.TakeDamage(1);
        }


        Destroy(gameObject); //destry bullet in all cases



    }
}
