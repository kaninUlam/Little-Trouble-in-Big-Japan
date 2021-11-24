using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiBehaviour : MonoBehaviour
{
    // The damage it deals to Player
    public float damageDealt;

    // Recognizes the Player Damage
    Health playerHP;

    // Hyogen
    public NavMeshAgent Hyogen;
    // Player
    public Transform Player;

    public virtual void Start()
    {
            
        // Identify and Chase the Player
        Player = GameObject.FindGameObjectWithTag("Player").transform;

        // NavMesh Agent Component so it will move independently around the map
        Hyogen = GetComponent<NavMeshAgent>();

        // Player HP
        playerHP = Player.GetComponent<Health>();

    }

    
    public virtual void Update()
    {
        FacePlayer();

        // Hyogen will chase after the Player
        Hyogen.SetDestination(Player.position);
    }

    public void FacePlayer()
    {
        // Hyogen will constantly look at Player
        Vector3 direction = (Player.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5);
    }

    // Collision with the Player and Emoji
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag == "Player") // If colliding with the Player
        {
            playerHP.takeDamage(damageDealt); // The Player takes Damage
        }

        if (collision.gameObject.tag == "Bullet") // When Colliding with Bullet
        {
            StartCoroutine(SlowDown()); // It Slows Down
        }
    }

    IEnumerator SlowDown()
    {
        gameObject.GetComponent<NavMeshAgent>().isStopped = true;
        yield return new WaitForSeconds(5);
        gameObject.GetComponent<NavMeshAgent>().isStopped = false;

        float maxSpeed = Hyogen.speed;
        Hyogen.speed = 0;
        while (Hyogen.speed < maxSpeed)
        {
            Hyogen.speed += 10 * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        Hyogen.speed = maxSpeed;
    }

}