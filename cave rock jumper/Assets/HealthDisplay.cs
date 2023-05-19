using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    private int health = 100;
    public Text healthtext;

    void Update()
    {
        healthtext.text = health.ToString();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            health--;
        }
    }
}
