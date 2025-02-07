using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    //~* === Use the comments in the code to complete this game === ~*//
    
    // === Create a Rigidbody2D variable for the projectile/bullet === //
      Rigidbody2D rigidbody2d;


    void Awake()
    {
        // === Write the code below to set your Rigidbody2D variable EQUAL to the Rigidbody2D component === //
        rigidbody2d = GetComponent<Rigidbody2D>();

    }
    
    public void Launch(Vector2 direction, float force)
    {
        // === Use your Rigidbody2D variable to add force to the projectile. Use the direction parameter from above and MULTIPLY it with the force parameter from above ===//
        // ~ HINT: use the ' AddForce() ' ~ //
        rigidbody2d.AddForce(direction * force);

    }
    
    void Update()
    {
        if(transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
    }
    
    // === Create a method below to detect the collision between the bullet and other GameObjects ( HINT: use  ' OnCollisionEnter2D() ' )  === //
    // === In the method, Destroy the gameObject and Destroy the other gameObject === //
  
  void OnCollisionEnter2D(Collision2D other)
  {
     Destroy(gameObject);
  }












}