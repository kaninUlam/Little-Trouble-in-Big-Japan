using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public DifferentPointSystem _Score;
    public GameObject Door;
    public GameObject OpenDoorObject;
    public int cost;

    bool playerInZone = false;
    private void Update()
    {
        if(playerInZone == true && Input.GetKeyDown(KeyCode.E))
        {
            if(_Score._PlayerScore>= cost)
            {
                _Score._PlayerScore -= cost;
                OpenDoor();
            }
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            OpenDoorObject.SetActive(true);
            playerInZone = true;
        }    
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            OpenDoorObject.SetActive(false);
            playerInZone = false;
        }
    }

    void OpenDoor()
    {
        OpenDoorObject.SetActive(false);
        Door.SetActive(false);
    }
}
