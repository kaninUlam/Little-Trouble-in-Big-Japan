using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Restart();
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void OnDeath()
    {
        SceneManager.LoadScene(3);
    }
}
