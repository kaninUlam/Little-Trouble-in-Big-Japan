using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGunAmmo : MonoBehaviour
{
    public Shotgun shotgunAmmo;
    public AudioSource aSource;
    public MeshRenderer mesh;
    public Collider boxCollider;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            aSource.Play();
            shotgunAmmo.ammo += 5;
            mesh.enabled = false;
            boxCollider.enabled = false;
            Destroy(gameObject, 5);

        }


    }

    private void Update()
    {
        
    }
}
