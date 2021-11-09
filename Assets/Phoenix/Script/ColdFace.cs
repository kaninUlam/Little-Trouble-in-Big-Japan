using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColdFace : AiBehaviour
{
    [SerializeField] private float startingHP = 150; // Max Enemy HP
    public float enemyHP; // current amount of health it has

    public float damageDealt; // The damage it deals to Player
    public float takeDamage = 50; //How much damage the enemy takes

    private pointSystem _uiManager;

    public GameObject healthPack; //Health Pack tied to the Enemy

    Health playerHP; // Recognizes the Player Damage

    private void Start()
    {
        enemyHP = startingHP; // enemy HP is the same as the Starting HP
        playerHP = Player.GetComponent<Health>(); // Player HP

        _uiManager = GameObject.Find("Canvas").GetComponent<pointSystem>();
    }

    private void Update()
    {
        if (enemyHP <= 0) //When Enemy HP is set to 0
        {
            Destroy(gameObject); // Destroys gameObject when it Dies

        }
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
