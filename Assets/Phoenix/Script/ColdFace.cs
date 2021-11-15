using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ColdFace : AiBehaviour
{
    public float damageDealt; // The damage it deals to Player
    public float takeDamage = 50; //How much damage the enemy takes

    private pointSystem _uiManager;

    Health playerHP; // Recognizes the Player Damage

    private void Start()
    {
        playerHP = Player.GetComponent<Health>(); // Player HP
        _uiManager = GameObject.Find("Canvas").GetComponent<pointSystem>();
    }

    private void OnCollisionEnter(Collision collision) // Collision with the Player and Emoji
    {
        if (collision.gameObject.tag == "Player") // If colliding with the Player
        {
            playerHP.takeDamage(damageDealt); // The Player takes Damage
        }

        if (collision.gameObject.tag == "Bullet")
        {
            if (_uiManager != null)
            {
                _uiManager.UpdateScore(20);
            }
        }
    }
}
