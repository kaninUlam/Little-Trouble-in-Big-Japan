using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    bool mouseOver = false;

    Vector3 pos;

    private void Start()
    {
        pos = transform.position;
    }

    private void OnMouseOver()
    {
        mouseOver = true;
        transform.position += Vector3.up; 
    }
    private void OnMouseExit()
    {
        mouseOver = false;
    }

    private void Update()
    {

        

        if(mouseOver == false)
        {
            transform.position = pos;
        }
    }

}
