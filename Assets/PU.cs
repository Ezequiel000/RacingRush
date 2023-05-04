using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PU : MonoBehaviour
{

    //public float speedMultiplier = 1000f;
    public float waitTime = 2f;
    //public float multiplier = 2f;


    //public GameObject pickupEffect;
    void OnTriggerEnter (Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }
    void Pickup(Collider player)
    {
       //Instantiate(pickupEffect, transform.position, transform.rotation);
       //spawn a cool effect here
       //apply effect to the player
       //stats.multiplier += multiplier;
       Debug.Log("Powerup picked up!");
    //PlayerStats stats = ArcadeKart.GetComponent<PlayerStats>();

    //    public ArcadeKart.StatPowerup boostStats = new ArcadeKart.StatPowerup
    //    stats.speed += speed;
    //    stats.acceleration += acceleration;
    //    stats.turning += turning;
    //    stats.braking += braking;
    //    stats.drift += drift;

       Destroy(gameObject);
    }

}
