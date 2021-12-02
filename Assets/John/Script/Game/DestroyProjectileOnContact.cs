using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectileOnContact : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy" && collision.gameObject.tag == "Cold")
        {
            Destroy(this);
        }
    }
}
