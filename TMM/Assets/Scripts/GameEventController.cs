using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameEventController : MonoBehaviour
{

    public static GameEventController instance;

    //Time Start
    float currentTime = 0f;
    //Level Time Select
    public float startingTime;

    public GameObject goPanel; //game over panel 
    public GameObject woPanel; //Level finish panel
    public GameObject wakeText; // <-----
    public GameObject player; // <----
    public GameObject Bed;

    public bool timeGo;
    public bool playerTouching = false;

    [SerializeField] Text countdownText;

    void Start()
    {
        instance = this;
        currentTime = startingTime;

        //Game Start
        wakeText.SetActive(true);
        timeGo = false;
    }


    void Update()
    {
        Timer();

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public void Timer()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            wakeText.SetActive(false);
            timeGo = true;
        }

        if (timeGo == true)
        {
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("00");

            if (currentTime <= 0)
            {
                currentTime = 0;
                goPanel.SetActive(true);
                PlayerController.instance.isSleeping = true;
            }
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitLevel()
    {
        SceneManager.LoadScene(0);
    }
}
