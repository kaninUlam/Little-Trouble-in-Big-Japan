using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiBehaviour : MonoBehaviour
{
    public enum Tracking { Attack, Chase}
    public Tracking trackType = Tracking.Attack;

    //Hyogen
    public NavMeshAgent Hyogen;
    //Player
    public Transform Player;

    public float range = 0.5f;
    int i = 0;


    void Start()
    {
        //Identify and Chase the Player
        Player = GameObject.FindGameObjectWithTag("Player").transform;

        //NavMesh Agent Component so it will move independently around the map
        Hyogen = GetComponent<NavMeshAgent>();

        //Audio for the Monster
        //Asource.GetComponent<AudioSource>();
    }

    
    void Update()
    {
            //Enum depends on chasing and attacking
            switch (trackType)
            {
                case Tracking.Attack:
                    Attack();
                    break;
                case Tracking.Chase:
                    ChasePlayer();
                    break;
            }
    }

    //Hyogen Attack System
    private void Attack()
    {
        //Chases Player for Attack
        Hyogen.SetDestination(transform.position);
        
    }

    private void ChasePlayer()
    {
        //Chases Player
        Hyogen.SetDestination(Player.position);

    }
}