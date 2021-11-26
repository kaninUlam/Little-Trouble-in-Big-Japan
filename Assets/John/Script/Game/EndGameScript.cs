using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGameScript : MonoBehaviour
{
    bool PlayerNearLadder = false;
    public GameObject Exit;

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
            Exit.SetActive(true);
            Debug.Log("Player near Ladder");
            PlayerNearLadder = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Exit.SetActive(false);
            Debug.Log("Player Left Ladder");
            PlayerNearLadder = false;
        }
    }
    void loadnextScene()
    {
        SceneManager.LoadScene(4);
    }
}
