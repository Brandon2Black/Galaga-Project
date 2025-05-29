using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //~* === Use the comments in the code to complete this game === ~*//

    // === Create a float variable for the speed of the enemy === //
    public float speed = 2.5f;
    
    // === Create a float variable for the change time of the enemy === //
    public float changetime = 2;

    // === Create a Rigidbody2D variable for the enemy === //
   Rigidbody2D rigidbody2d;

    // === Create a float varaible for the timer of the enemy === //
  public float timer = 2;

    // === Create an int varaible for the direction of the enemy and set it EQUAL to 1 === //
    public int direction = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        // === Write the code below to set your Rigidbody2D variable EQUAL to the Rigidbody2D component === //
                rigidbody2d = GetComponent<Rigidbody2D>();

        // === Set the timer variable EQUAL to the change time variable below === //
       timer = changetime;
    }

    void Update()
    {
        // === Set the timer variable to be MINUS EQUALS " -= " to the Time.deltaTime === //
          timer -= Time.deltaTime;

       {
       if (timer < 0)
        {
          direction = -direction;
          timer = changetime;
        }
       } // === Create an if-statement below that checks when the timer variable is LESS THAN 0 === //
      
        // === Inside the if-statement set the direction variable to be EQUAL to MINUS of the direction variable === //
        // === Also inside the if-statement, set the timer variable back EQUAL to the change time variabel === //


    }

    void FixedUpdate()
    {
        // === Create a private Vector2 variable and set it EQUAL to your Rigidbody2D variable's .position === //
        Vector2 rigidbodypos = rigidbody2d.position;
    
        // === Get the x value of your Vector2 variable and set it EQUAL to itself MULTIPLIED by your speed variable MULTIPLIED by your direction variable MULTIPLIED by Time.deltaTime === //
       rigidbodypos.x = rigidbodypos.x + speed * direction * Time.deltaTime;

        // === Use the .MovePosition() method with your Rigidbody2D variable and put your Vector2 varaible name in between the " () " parentheses === //
       rigidbody2d.MovePosition(rigidbodypos);
    }
}