using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PukeFace : AiBehaviour
{

    public float damageDealt; //The damage it deals to Player
    public float takeDamage = 50; //How much damage the enemy takes

    private pointSystem _uiManager; //From pointSystem Script it will be called uiManager

    private GameObject healthPack; //Health Pack tied to the Enemy

    Health playerHP; //Recognizes the Player Damage

    private void Start()
    {
        playerHP = Player.GetComponent<Health>(); // Player HP

        _uiManager = GameObject.Find("Canvas").GetComponent<pointSystem>(); //If the gameobject Canvas has pointSystem in it
    }

    private void OnCollisionEnter(Collision collision) //Collision with the Player and Emoji
    {
        if (collision.gameObject.tag == "Player") //If colliding with the Player
        {
            playerHP.takeDamage(damageDealt); //The Player takes Damage
        }

        if (collision.gameObject.tag == "Bullet") //Colliding with bullet
        {
            if (_uiManager != null) 
            {
                _uiManager.UpdateScore(20); //Sends 20 Points to UI
            }
        }
    }
}
