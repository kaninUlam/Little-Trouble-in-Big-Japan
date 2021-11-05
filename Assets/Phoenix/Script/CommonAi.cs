﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CommonAi : AiBehaviour
{
    [SerializeField] private float startingHP = 100; // Max Enemy HP
    public float enemyHP; // current amount of health it has

    public float damageDealt; // The damage it deals out to the player

    public GameObject healthPack; //Health Pack tied to the Enemy

    private int damageTaken = 20; // The amount of Damage it takes

    Health playerHP; // Recognizes the Player Damage

    private void Start()
    {
        enemyHP = startingHP; // enemy HP is the same as the Starting HP
        playerHP = Player.GetComponent<Health>(); // Player HP
        StartCoroutine(attackDelay()); // For delays between hit recognization
    }

    IEnumerator attackDelay() // Attack Delay Script
    {
        yield return new WaitForSeconds(5); // Wait after 5 Seconds
    }

    public float GetCurrentHP() //Current HP
    {
        return enemyHP;
    }

    private void Update()
    {
        if (enemyHP <= 0) //When Enemy HP is set to 0
        {
            Instantiate(healthPack, transform.position, Quaternion.identity); //Leaves a Health Pack for the Player
            Destroy(gameObject); // Destroys gameObject when it Dies
        }
    }

    private void OnCollisionEnter(Collision collision) // Collision with the Player and Emoji
    {
        if (collision.gameObject.tag == "Player") // If colliding with the Player
        {
            playerHP.takeDamage(damageDealt); // The Player takes Damage
        }
    }
}
