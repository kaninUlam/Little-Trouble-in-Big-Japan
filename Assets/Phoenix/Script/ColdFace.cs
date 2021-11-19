using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ColdFace : AiBehaviour
{
    //bool canMove = false;

    public override void Start()
    {
        base.Start();

    }

    public override void Update()
    {
        base.Update();
        
    }

    private void Freeze(Collision collision) 
    {
        if (collision.gameObject.tag == "Player")
        {

        }
    }
}
