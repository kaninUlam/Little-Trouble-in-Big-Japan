using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiBehaviour : MonoBehaviour
{
    public enum Tracking { Attack, Chase}
    public Tracking trackType = Tracking.Attack;

    //Audio (Will be commented out if unnecessary)
    public AudioSource Asource = null;

    //Hydogen
    public NavMeshAgent Hydogen;
    //Player
    public Transform Player;

    public float range = 0.5f;
    int i = 0;


    void Start()
    {
        //Identify and Chase the Player
        Player = GameObject.FindGameObjectWithTag("Player").transform;

        //NavMesh Agent Component so it will move independently around the map
        Hydogen = GetComponent<NavMeshAgent>();

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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

        }
    }

    //Hydogen Attack System
    private void Attack()
    {
        //Chases Player for Attack


    }

    private void ChasePlayer()
    {
        //Chases Player
        Hydogen.SetDestination(Player.position);
        transform.LookAt(Player);
    }
}