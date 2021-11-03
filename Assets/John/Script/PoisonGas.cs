using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonGas : MonoBehaviour
{
    public bool Poisoned = false;
    public float PoisonDamage = 0.25f;
    public GameObject Player;
    public Health DamageTaken;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        DamageTaken = Player.GetComponent<Health>();
    }
    private void Update()
    {
        if(Poisoned == true)
        {
            DamageTaken.TakeDamageOverTime(PoisonDamage);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Poisoned = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Poisoned = false;
        }
    }
}
