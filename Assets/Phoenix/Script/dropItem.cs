using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}