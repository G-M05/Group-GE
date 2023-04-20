using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public Transform player;
    //Reference to waypoints
    public List<Transform> Points;
    //create an int that will represent our indexed transforms in our list
    public int nextId;
    //help us change our net Id value
    private int idChangeValue = 1;
    //set the speed of our enemy
    public float speed;

   
    void Update()
    {
        

        if(Vector2.Distance(transform.position, player.position) < 5f)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else
        {
            MoveToNextPoint();
        }
       
    }


    void MoveToNextPoint()
    {
        //set and get a goal point ased off out lists index
        Transform goalPoint = Points[nextId];
        
        //flip the enemy to look at the next goalPoint
        // might change based off of your sprites natural direction
        if (goalPoint.transform.position.x > transform.position.x)
        {                                      
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        //move our enemy towards our goalPoint
        transform.position = Vector2.MoveTowards(transform.position, goalPoint.position, speed * Time.deltaTime);
        //check the distance between the enemy and the goalPoint to trigger the next point
        if(Vector2.Distance(transform.position, goalPoint.position)<1f)
        {
            //chack if we are at the end of our waypoints, if so -1 from our index
            if (nextId == Points.Count -1)
            {
                idChangeValue = -1;
            }
            //check if we are the start of out waypoints if so +1
            if(nextId ==0)
            {
                idChangeValue = 1;
            }
            nextId += idChangeValue;
        }
    } 

    // Update is called once per frame
    
}
