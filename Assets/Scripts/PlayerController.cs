using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    //~* === Use the comments in the code to complete this game === ~*//

    // === Create a float variable for the speed of the player === //
    public float speed = 2.0f;
    // === Create a Rigidbody2D variable for the player === //

    Rigidbody2D rigidbody2d;

    // === Create a float variable for the player's Left and Right input === //
    public float horizontal;
    
    // === Create a public GameObject variable for the projectile prefab === //
    public GameObject projectilePrefab;
    
    public static TextMeshProUGUI scoreText;

    public static int score = 0;
    void Start()
    {
        // === Write the code below to set your Rigidbody2D variable EQUAL to the Rigidbody2D component === //
            rigidbody2d = GetComponent<Rigidbody2D>();
            scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        // === Write the code below to set your input float variable EQUAL to the player's horizontal inputs (HINT: use ' Input.GetAxis() ') === //
       horizontal = Input.GetAxis("Horizontal");

       Vector2 position = transform.position;
       position.x = position.x + speed * horizontal * Time.deltaTime;
       transform.position = position;
        // === Create an if-statement below to get the player's key down and then call the method to launch your projectile/bullet === //
        // ~ HINT: use ' Input.GetKeyDown() ' ~ //
       if(Input.GetKeyDown(KeyCode.C))
       {
         GameObject projectileObject = Instantiate(projectilePrefab, transform.position + Vector3.up * 1.25f, projectilePrefab.transform.rotation);
         ProjectileController projectile = projectileObject.GetComponent<ProjectileController>();
         projectile.Launch(Vector2.up, 310);
       }
    


    }


    public static void UpdateScore()
  {
 scoreText.text = "Score: " + score.ToString();
  }
    void Launch()
    {
        // === Add the code below to launch your projectile UP towards the enemy === //










    }
    
}