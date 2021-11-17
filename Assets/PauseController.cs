﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    bool _isPaused;
    

    public GameObject PauseMenu;
    public GameObject _Hud;

    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.SetActive(false);
        _Hud.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Cancel"))
        {
            TogglePause();
        }

        

    }

    public void MainMenuTransition()
    {
        SceneManager.LoadScene(0);
    }

    public void TogglePause()
    {
        
        _isPaused = !_isPaused;
        Time.timeScale = _isPaused ? 0f : 1f;
        PauseMenu.SetActive(_isPaused);
        _Hud.SetActive(!_isPaused);
        
    }

}