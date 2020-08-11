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

    public GameObject gameOverPanel;
    public GameObject wonPanel;
    public GameObject wakeText;
    public GameObject player;
    public GameObject timeToGoText;
    public GameObject playerInventory;
    public GameObject objectInventory;

    public GameObject wardrobe;
    public GameObject breakfast;
    public GameObject sink;
    public GameObject levelFinish;

    private int objectiveCount = 0;
    private int clothesCount = 0;
    private int foodCount = 0;

    public bool isEasyLevel;

    public bool timeGo;

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
                playerInventory.SetActive(false);
                objectInventory.SetActive(false);
                gameOverPanel.SetActive(true);
                timeToGoText.SetActive(false);
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

    public void AddFood()
    {
        foodCount++;
        if(foodCount == 3)
        {
            breakfast.SetActive(true);
        }
    }

    public void AddClothes()
    {
        clothesCount++;
        if (clothesCount == 3)
        {
            wardrobe.SetActive(true);
        }
    }

    public void FoundToothbrush()
    {
        sink.SetActive(true);
    }

    public void FoundKeys()
    {
        objectiveCount++;
    }

    public void ObjectiveComplete()
    {
        objectiveCount++;
        if (isEasyLevel)
        {
            if (objectiveCount == 3)
            {
                levelFinish.SetActive(true);
                timeToGoText.SetActive(true);
            }
        }
        else
        {
            if (objectiveCount == 5)
            {
                levelFinish.SetActive(true);
                timeToGoText.SetActive(true);
            }
        }
    }
}
