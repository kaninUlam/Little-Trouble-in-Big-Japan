using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameCheck : MonoBehaviour
{
    public GameObject wincollider;
    public CheckForObjectives completed; 
    // Update is called once per frame
    void Update()
    {
        if(completed.allperksareactive == true)
        {
            wincollider.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (completed.allperksareactive == true)
            {
                wincollider.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (completed.allperksareactive == true)
            {
                wincollider.SetActive(false);
            }
        }
    }
}
