using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CommonAi : AiBehaviour
{
    [SerializeField] private float startingHP = 100; // Max Enemy HP
    public float enemyHP; // current amount of health it has

    public float damageDealt; // The damage it deals out to the player

    private int damageTaken = 20; // The amount of Damage it takes

    private pointSystem _uiManager;

    Health playerHP; // Recognizes the Player Damage

    private void Start()
    {
        enemyHP = startingHP; // enemy HP is the same as the Starting HP
        playerHP = Player.GetComponent<Health>(); // Player HP

        _uiManager = GameObject.Find("Canvas").GetComponent<pointSystem>();
    }

    public float GetCurrentHP() //Current HP
    {
        return enemyHP;
    }

    private void Update()
    {
        if (enemyHP <= 0) // When Enemy HP is set to 0
        {
            EnemyDeath(); // Code below this one
        }
    }

    public void EnemyDeath()
    {
        Destroy(gameObject); // Destroys gameObject when it Dies
    }

    private void OnCollisionEnter(Collision collision) // Collision with the Player and Emoji
    {
        if (collision.gameObject.tag == "Player") // If colliding with the Player
        {
            playerHP.takeDamage(damageDealt); // The Player takes Damage
        }

        if (collision.gameObject.tag == "Bullet") //When colliding with the bullet
        {
            if (_uiManager != null)
            {
                _uiManager.UpdateScore(10); //Sends points to the UI
            }
        }
    }
}
