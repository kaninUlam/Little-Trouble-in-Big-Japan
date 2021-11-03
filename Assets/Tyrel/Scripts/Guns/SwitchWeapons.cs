using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapons : MonoBehaviour
{

    public int weaponSelected = 0;

    public GameObject Shotgun;
    public GameObject AssualtRifle;
    public GameObject Sniper;

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

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            weaponSelected = 3;
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 1)
        {
            weaponSelected = 3;
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
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
                Sniper.SetActive(false);
                break;

            case 2:
                Shotgun.SetActive(true);
                AssualtRifle.SetActive(false);
                Sniper.SetActive(false);
                break;

            case 3:
                Sniper.SetActive(true);
                Shotgun.SetActive(false);
                AssualtRifle.SetActive(false);
                break;
        }


    }
}
