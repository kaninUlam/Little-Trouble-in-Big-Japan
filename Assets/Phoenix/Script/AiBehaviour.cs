using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiBehaviour : MonoBehaviour
{
    //States
    public enum Tracking { Attack, Chase} 
    public Tracking trackType = Tracking.Attack;

    private pointSystem _uiManager;

    // Recognizes the Player Damage
    Health playerHP; 
    public float damageDealt;

    //Hyogen
    public NavMeshAgent Hyogen;
    //Player
    public Transform Player;

    public float range = 0.5f;

    void Start()
    {
        //Identify and Chase the Player
        Player = GameObject.FindGameObjectWithTag("Player").transform;

        //NavMesh Agent Component so it will move independently around the map
        Hyogen = GetComponent<NavMeshAgent>();

        playerHP = Player.GetComponent<Health>(); // Player HP

        _uiManager = GameObject.Find("Canvas").GetComponent<pointSystem>();

    }

    
    void Update()
    {
        //Look at Player while chasing
        Vector3 lookVector = Player.transform.position - transform.position;
        lookVector.y = transform.position.y;
        Quaternion rot = Quaternion.LookRotation(lookVector);
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, 1);

            //Enum depends on chasing and attacking
            switch (trackType)
            {
                //case Tracking.Attack:
                //    Attack();
                //    break;
                case Tracking.Chase:
                    ChasePlayer();
                    break;
            }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") // If colliding with the Player
        {
            playerHP.takeDamage(damageDealt); // The Player takes Damage
        }

        if (collision.gameObject.tag == "Bullet")
        {
            Time.timeScale = 0.8f;
            //if (_uiManager != null)
            //{
            //    _uiManager.UpdateScore(20);
            //}
        }
    }

    //Hyogen Attack System
    //private void Attack()
    //{
    //    //Chases Player for Attack
    //    Hyogen.SetDestination(transform.position);

        
    //}

    private void ChasePlayer()
    {
        //Chases Player
        Hyogen.SetDestination(Player.position);

    }
}