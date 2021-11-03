using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapons : MonoBehaviour
{

    public int weaponSelected = 0;

    public GameObject Shotgun;
    public GameObject AssualtRifle;


    void Start()
    {
        weaponSelected = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weaponSelected = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            weaponSelected = 2;
        }

        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            weaponSelected = 2;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            weaponSelected = 1;
        }

        switch (weaponSelected)
        {
            case 1:
                Shotgun.SetActive(false);
                AssualtRifle.SetActive(true);
                
                break;

            case 2:
                Shotgun.SetActive(true);
                AssualtRifle.SetActive(false);
                break;


        }


    }
}
