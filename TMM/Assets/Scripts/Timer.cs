using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime = 30f;
    public GameObject goPanel; //game over panel 

    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startingTime;  
    }

   
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("00");

        if (currentTime <= 0)
        {
            currentTime = 0;
            goPanel.SetActive(true);
            Time.timeScale = 0;
            //PlayerController.instance.interacting = true; //Proably a better way to do this
        }
    }
}
