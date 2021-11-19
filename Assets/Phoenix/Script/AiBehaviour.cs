using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiBehaviour : MonoBehaviour
{
    //public enum Tracking { Attack, Chase} //States
    //public Tracking trackType = Tracking.Attack;

    public float damageDealt; // The damage it deals to Player

    //Recognizes the Player Damage
    Health playerHP;

    //Hyogen
    public NavMeshAgent Hyogen;
    //Player
    public Transform Player;

    public virtual void Start()
    {
            
        //Identify and Chase the Player
        Player = GameObject.FindGameObjectWithTag("Player").transform;

        //NavMesh Agent Component so it will move independently around the map
        Hyogen = GetComponent<NavMeshAgent>();

        playerHP = Player.GetComponent<Health>(); // Player HP

    }

    
    public virtual void Update()
    {
        FacePlayer();

        // Hyogen will chase after the Player
        Hyogen.SetDestination(Player.position);

        //Enum depends on chasing and attacking
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

    public void FacePlayer()
    {
        // Hyogen will constantly look at Player
        Vector3 direction = (Player.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5);
    }

    private void OnCollisionEnter(Collision collision) // Collision with the Player and Emoji
    {
        if (collision.gameObject.tag == "Player") // If colliding with the Player
        {
            playerHP.takeDamage(damageDealt); // The Player takes Damage
        }

        if (collision.gameObject.tag == "Bullet")
        {
            StartCoroutine(SlowDown());
        }
    }

    IEnumerator SlowDown()
    {
        gameObject.GetComponent<NavMeshAgent>().isStopped = true;
        yield return new WaitForSeconds(5);
        gameObject.GetComponent<NavMeshAgent>().isStopped = false;

        //float maxSpeed = Hyogen.speed;
        //Hyogen.speed = 0;
        //while (Hyogen.speed < maxSpeed)
        //{
        //    Hyogen.speed += 10 * Time.deltaTime;
        //    yield return new WaitForEndOfFrame();
        //}
        //Hyogen.speed = maxSpeed;
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