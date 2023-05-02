using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    public float speed = 6;
    //create a storage for our Transform
    Transform player;
    // create a storage loarion for a bool ro xhack if boss is flipped
    public bool isFlipped = false;
    // a box that stores the bosses rigidbody
    Rigidbody2D rb;
    //creat a health variable called boss health
    public int bossHealth = 10;
    public float attackRange = 3.5f;
    // crate a series of bools to help transition us to our different phases
    public bool phase2 = false;
    public bool phase3 = false;
    public bool isDead = false;
   
    //create a stoarage for our player manager
    playerManager PlayerManager;
   
    //create a location for our bullet to start from
    public Transform shotLocation;
    public GameObject projectile;
    public GameObject projectile2;
    // create timer system / cooldown
    public float timer;
    public float coolDown;
    //Create a function for this attack (create the bullet)
    
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        //sets and grabs the infor we need to call our functions
        PlayerManager = GameObject.FindGameObjectWithTag("Player").GetComponent<playerManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //create a series of if else statements that will check to see if the boss is
        //below 7 and above 3, below 3 and above 1, and less than or equal to 0
        if(bossHealth < 7 && bossHealth > 3)
        {
            speed = 2f;
            attackRange = 6f;
            phase2 = true;
            Debug.Log("Phase 2");
        }
        
        else if (bossHealth < 3 && bossHealth >= 1)
        {
            phase2 = false;
            speed = 1;
            attackRange = 2;
            phase3 = true;
            Debug.Log("Phase 3");
        }
        else if(bossHealth <= 0)
        {
            phase3 = false;
            isDead = true;
            Debug.Log("isDead");
        }
        timer = Time.deltaTime;
    }

    public void projectileShoot()
    {
        if(timer >coolDown)
        {
            if(phase2)
            {
                GameObject clone = Instantiate(projectile, shotLocation.position, Quaternion.identity);
                timer = 0;
            }

            else if(phase3)
            {
                GameObject clone = Instantiate(projectile2, shotLocation.position, Quaternion.identity);
                timer = 0;
            }
           
        }
    }

    //boss will flip depending on which side the player is on use true or false statements
    public void LookAtPlayer()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;
        // bosses position
        if(transform.position.x > player.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0, 180, 0);
            isFlipped = false;
        }
        else if(transform.position.x < player.position.x && !isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0, 180, 0);
            isFlipped = true;
        }
    }

    // if tag "player" is being used and an attack hits it will deal damage
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            PlayerManager.TakeDamage(20);
        }
    }
}
