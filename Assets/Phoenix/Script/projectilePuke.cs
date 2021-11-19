using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class projectilePuke : MonoBehaviour
{
    Health playerHP; // Player Health

    public float damageDealt; // Damage

    public GameObject Player; // Player Object

    public void Start()
    {
        playerHP = Player.GetComponent<Health>(); // Puke Component recognizes playerHP as a component of Player
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") // If colliding with the Player
        {
            playerHP.takeDamage(damageDealt); // The Player takes Damage
            Destroy(gameObject, 1f); // Object is Destroyed
        }
    }
}
