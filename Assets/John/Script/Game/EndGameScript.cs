using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour
{
    bool PlayerNearLadder = false;

    public DifferentPointSystem _currentscore;
    private void Update()
    {
        if(PlayerNearLadder == true && Input.GetKeyDown(KeyCode.E))
        {
            if(_currentscore._PlayerScore >= 10000)
            {
                loadnextScene();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player near Ladder");
            PlayerNearLadder = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player Left Ladder");
            PlayerNearLadder = false;
        }
    }
    void loadnextScene()
    {
        SceneManager.LoadScene(4);
    }
}
