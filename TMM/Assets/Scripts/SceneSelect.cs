﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSelect : MonoBehaviour
{
    public void LevelStart()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    //We could proably use a array for level list 
    public void LevelNext()
    {
        SceneManager.LoadScene(2);
    }

    public bool touching;
    GameObject player;
    public GameObject woPanel;
    public GameObject T1, T2, T3;
    public GameObject GoText;

    private void Update()
    {
        LevelendInput();

    }

    //Don't look as this 
    void LevelendInput()
    {
        if (T1.activeInHierarchy && T2.activeInHierarchy & T3.activeInHierarchy && !woPanel.activeInHierarchy == true)
        {
            GoText.SetActive(true);
        }
       

        if (touching == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GoText.SetActive(false);
                if (T1.activeInHierarchy && T2.activeInHierarchy & T3.activeInHierarchy)
                {
                    woPanel.SetActive(true);
                }
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            touching = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            touching = false;
        }
    }
}
