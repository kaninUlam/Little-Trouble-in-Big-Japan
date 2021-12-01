using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForObjectives : MonoBehaviour
{
    public bool allperksareactive = false;
    public GameObject perk1;
    public GameObject perk2;
    public GameObject perk3;
    public GameObject perk4;
    void Update()
    {
        if(perk1.activeInHierarchy ==true && perk2.activeInHierarchy == true && perk3.activeInHierarchy == true && perk4.activeInHierarchy == true)
        {
            allperksareactive = true;
        }
    }
}
