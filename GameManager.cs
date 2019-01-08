﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public bool isGameStarted;
	// Use this for initialization
	void Start () {
        isGameStarted = false;

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
        }
		
	}

    private void StartGame()
    {
        isGameStarted = true;
    }

    internal void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
