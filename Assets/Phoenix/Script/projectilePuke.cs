using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class projectilePuke : MonoBehaviour
{
    public float lifeTime = 3.0f;

    public float moveSpeed = 50.0f;

    public float damage;

    public Health playerHP;

    public Transform Player;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;

        Destroy(this.gameObject, lifeTime); // Destroys game Object

        playerHP = Player.GetComponent<Health>();
    }

    void Update()
    {
        Speed();
    }

    private void Speed()
    {
        transform.position += Time.deltaTime * moveSpeed * transform.forward;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHP.takeDamage(damage);
            
            Destroy(gameObject);
        }
    }
}
