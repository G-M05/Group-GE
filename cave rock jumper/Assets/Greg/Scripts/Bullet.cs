using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullets;
    public Transform FirePoint;
    
   

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
             
            
        }
    }
    void Shoot()
    {
        Instantiate(bullets, FirePoint.position, FirePoint.rotation);
   

    }
}
