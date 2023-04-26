using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform BulletSpawnPoint;
    public GameObject bullets;
    public float bulletSpeed = 10;
    Rigidbody2D rb;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            var bullet = Instantiate(bullets, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = BulletSpawnPoint.right * bulletSpeed;
        }
    }
}
