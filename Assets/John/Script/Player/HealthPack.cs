using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public GameObject player;
    public Health healthup;
    public float heal = 10;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        healthup = player.GetComponent<Health>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            healthup.currentHealthPoints += heal;
            Destroy(gameObject);
        }
    }
}
