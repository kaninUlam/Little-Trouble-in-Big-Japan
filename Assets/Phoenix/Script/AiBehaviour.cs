﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiBehaviour : MonoBehaviour
{
    //public enum Tracking { Attack, Chase} //States
    //public Tracking trackType = Tracking.Attack;

    //From pointSystem Script it will be called uiManager
    private pointSystem _uiManager;

    public float damageDealt; // The damage it deals to Player

    //Recognizes the Player Damage
    Health playerHP;

    //Hyogen
    public NavMeshAgent Hyogen;
    //Player
    public Transform Player;

    //public float range = 0.5f;
    //int i = 0;


    public virtual void Start()
    {
            
        //Identify and Chase the Player
        Player = GameObject.FindGameObjectWithTag("Player").transform;

        //NavMesh Agent Component so it will move independently around the map
        Hyogen = GetComponent<NavMeshAgent>();

        playerHP = Player.GetComponent<Health>(); // Player HP

        _uiManager = GameObject.Find("Canvas").GetComponent<pointSystem>();


    }

    
    public virtual void Update()
    {
        // Hyogen will constantly look at Player
       /* Vector3 lookVector = Player.transform.position - transform.position;
        lookVector.y = transform.position.y;
        Quaternion rot = Quaternion.LookRotation(lookVector);
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, 1);*/

        // Hyogen will chase after the Player
        Hyogen.SetDestination(Player.position);

        //        //Enum depends on chasing and attacking
        //        switch (trackType)
        //        {
        //            case Tracking.Attack:
        //                Attack();
        //                break;
        //            case Tracking.Chase:
        //                ChasePlayer();
        //                break;
        //        }
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
            StartCoroutine(SlowDown());
        }
    }

    IEnumerator SlowDown()
    {
        float maxSpeed = Hyogen.speed;
        Hyogen.speed = 0;
        while (Hyogen.speed < maxSpeed)
        {
            Hyogen.speed += 5 * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        Hyogen.speed = maxSpeed;
    }

    ////Hyogen Attack System
    //private void Attack()
    //{
    //    //Chases Player for Attack
    //    Hyogen.SetDestination(transform.position);


    //}

    //private void ChasePlayer()
    //{
    //    //Chases Player
    //    Hyogen.SetDestination(Player.position);

    //}
}