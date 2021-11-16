using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Over : MonoBehaviour
{
    bool mouseOver = false;

    Vector3 pos;
    Vector3 newPos;




    private void Start()
    {


        pos = transform.position;
        newPos = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
    }

    private void OnMouseOver()
    {
        mouseOver = true;

        transform.position = newPos;

    }
    private void OnMouseExit()
    {
        mouseOver = false;
    }





    private void Update()
    {



        if (mouseOver == false)
        {
            transform.position = pos;
        }
    }

}
