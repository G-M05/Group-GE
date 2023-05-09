using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullets;
   

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            
             Instantiate(bullets, gameObject.transform.position, Quaternion.identity);
            
        }
    }
}
