using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
    PlayerMovement PlayerMovement;
    public int coinCount;

    //set a max health
    public int maxHealth;
    public int currentHealth;

    void Start()
    {
        PlayerMovement = GetComponent<PlayerMovement>();
    }
    public bool PickupItem(GameObject obj)
    {
        switch (obj.tag)
        {
            case "money":
                coinCount++;
                return true;
            case "speed+":
                PlayerMovement.SpeedPowerUp();
                //call function here
                return true;
            default:
                Debug.Log("Item tag or reference not set.");
                return false;

        }


    }
    private void Update()
    {
        if (currentHealth <= 0)
        {
            PauseGame();
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
    }

    private void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
