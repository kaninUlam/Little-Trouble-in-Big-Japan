using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PukeFace : AiBehaviour
{
    public enum Attack { Puke, Reset }
    Attack attackType = Attack.Puke;

    public float timeBetweenAttack;
    private bool alreadyAttacked;

    public GameObject puke;

    public void Start()
    {
        
    }

    public void Update()
    {
       switch (attackType)
       {
            case Attack.Puke: 
                Puke();
                break;
            case Attack.Reset:
                Attacking();
                break;
       }
    }

    private void Puke()
    {
        Hyogen.SetDestination(transform.position);

        transform.LookAt(Player);

        if (!alreadyAttacked)
        {
            Rigidbody rb = Instantiate(puke, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);

            //

            alreadyAttacked = true;
            Invoke(nameof(Attacking), timeBetweenAttack);
        }
    }

    private void Attacking()
    {
        alreadyAttacked = false;
        Hyogen.SetDestination(Player.position);
    }

    /*public float damageDealt;*/ //The damage it deals to Player

    /*private pointSystem _uiManager;*/ //From pointSystem Script it will be called uiManager

    /*Health playerHP;*/ //Recognizes the Player Damage

    //private void Start()
    //{
    //    playerHP = Player.GetComponent<Health>(); // Player HP

    //    _uiManager = GameObject.Find("Canvas").GetComponent<pointSystem>(); //If the gameobject Canvas has pointSystem in it
    //}

    //private void OnCollisionEnter(Collision collision) //Collision with the Player and Emoji
    //{
    //    if (collision.gameObject.tag == "Player") //If colliding with the Player
    //    {
    //        playerHP.takeDamage(damageDealt); //The Player takes Damage
    //    }

    //    if (collision.gameObject.tag == "Bullet") //Colliding with bullet
    //    {
    //        if (_uiManager != null) 
    //        {
    //            _uiManager.UpdateScore(20); //Sends 20 Points to UI
    //        }
    //    }
    //}
}
