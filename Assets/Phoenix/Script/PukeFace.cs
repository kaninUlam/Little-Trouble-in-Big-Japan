using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PukeFace : AiBehaviour
{
    
    //public float attackRange = 0;
    public float attackDelay = 5;
    //private float nextAttack = 0;
    private float attackDelayTimer = 0;

    public GameObject puke;

    public override void Start()
    {
        base.Start();

    }

    public override void Update()
    {
        base.Update();
        ShootPlayer();
    }

    private void ShootPlayer()
    {
        attackDelayTimer -= Time.deltaTime;

        if (attackDelayTimer >= 0) return;

        attackDelayTimer = attackDelay;

        GameObject pukeProjectile = Instantiate(puke, transform.position, transform.rotation);
        Rigidbody rb = pukeProjectile.GetComponent<Rigidbody>();
        float speed = rb.velocity.magnitude;
        rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
        rb.AddForce(transform.up * 4f, ForceMode.Impulse);
        Destroy(pukeProjectile, 2);


        //Rigidbody rb = Instantiate(puke, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
        //rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
        //rb.AddForce(transform.up * 2f, ForceMode.Impulse);
        //Destroy(puke, 0.1f);
    }
}
