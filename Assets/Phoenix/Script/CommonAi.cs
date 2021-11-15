using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CommonAi : AiBehaviour
{
    /*public float damageDealt;*/ // The damage it deals out to the player

    //private int damageTaken = 0; // The amount of Damage it takes

    //private pointSystem _uiManager;

    //Health playerHP; // Recognizes the Player Damage

    //private void Start()
    //{
    //    playerHP = Player.GetComponent<Health>(); // Player HP

    //    _uiManager = GameObject.Find("Canvas").GetComponent<pointSystem>();
    //}

    //private void OnCollisionEnter(Collision collision) // Collision with the Player and Emoji
    //{
    //    if (collision.gameObject.tag == "Player") // If colliding with the Player
    //    {
    //        playerHP.takeDamage(damageDealt); // The Player takes Damage
    //    }

    //    if (collision.gameObject.tag == "Bullet") //When colliding with the bullet
    //    {
    //        if (_uiManager != null)
    //        {
    //            _uiManager.UpdateScore(10); //Sends points to the UI
    //        }
    //    }
    //}
}
