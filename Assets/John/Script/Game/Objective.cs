using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    public GameObject ObjectiveText;
    public float timerforobjective;
    

    // Update is called once per frame
    void Update()
    {
        timerforobjective -= Time.deltaTime;
        if(timerforobjective<= 0)
        {
            ObjectiveText.SetActive(false);
        }
    }
}
