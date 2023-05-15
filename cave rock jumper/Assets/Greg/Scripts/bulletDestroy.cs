using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDestroy : MonoBehaviour
{

    //checks to see if bullet colides with something if it does the bullet gets destroyed
    private void OnTriggerEnter2D(Collider2D collision)
    {

        // Enemies to take damage
        if (collision.gameObject.TryGetComponent<EnemyAi>(out EnemyAi enemyComponent))
        {

            enemyComponent.TakeDamage(1);

        }
<<<<<<< Updated upstream
        else if (collision.gameObject.TryGetComponent<BossBehavior>(out BossBehavior bossComponent))
=======
        else if(collision.gameObject.TryGetComponent<BossBehavior>(out BossBehavior bossComponent))
>>>>>>> Stashed changes
        {
            bossComponent.TakeDamage(1);
        }


        Destroy(gameObject); //destry bullet in all cases



    }
}
