using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public DifferentPointSystem _Score;
    public GameObject Door;
    public int ScoreNeeded;

    bool playerInZone = false;
    // Start is called before the first frame update
    void Start()
    {
        _Score = GetComponent<DifferentPointSystem>();
    }
    private void Update()
    {
        if(playerInZone == true && Input.GetKeyDown(KeyCode.E))
        {
            if(_Score._PlayerScore>= 10000)
            {
                OpenDoor();
            }
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playerInZone = true;
        }    
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playerInZone = false;
        }
    }

    void OpenDoor()
    {
        Door.SetActive(false);
    }
}
