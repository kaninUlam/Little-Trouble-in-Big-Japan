using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    public float Speed = 800;

    
    void Update()
    {
        
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
}
