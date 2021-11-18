using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class projectilePuke : MonoBehaviour
{
    Health playerHP;

    public float damageDealt;

    public GameObject Player;

    public void Start()
    {
        playerHP = Player.GetComponent<Health>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") // If colliding with the Player
        {
            playerHP.takeDamage(damageDealt); // The Player takes Damage
            Destroy(gameObject);
        }
    }
}
