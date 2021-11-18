﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100f))
            {


                if (hit.transform.gameObject.tag == "Start")
                {
                    SceneManager.LoadScene(1);
                }
                

                if (hit.transform.gameObject.tag == "Exit")
                {
                    Debug.Log("exit");
                    Application.Quit();
                }

            }
        }
    }
}
