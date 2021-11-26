using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperAmmo : MonoBehaviour
{
    public Sniper sniper;
    public AudioSource aSource;
    public MeshRenderer mesh;
    public Collider boxCollider;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            aSource.Play();
            sniper.ammo += 5;
            mesh.enabled = false;
            boxCollider.enabled = false;
            Destroy(gameObject, 5);
            
        }

       
    }

    private void Update()
    {
        
    }
}
