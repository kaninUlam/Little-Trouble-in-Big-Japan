using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRight : MonoBehaviour
{

    public float Speed = -50;


    void Update()
    {

        transform.Translate(Vector3.right * Speed * Time.deltaTime);
    }
}

