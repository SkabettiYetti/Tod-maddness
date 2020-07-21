using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableController : MonoBehaviour
{

    public static InteractableController instance;

    public bool hasBeenUsed = false;
    public bool playerTouching = false;
    public bool isFinish = false;

    public GameObject player;
    public GameObject Finish;
    public GameObject tick;
    public GameObject exclamationMark;

    public void Start()
    {
        instance = this;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (playerTouching && !hasBeenUsed)
            {
                player.GetComponent<PlayerController>().Interact(this);
                hasBeenUsed = true;
            }
        }

        //Currently not working
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (playerTouching && isFinish)
            {
                PlayerController.instance.interacting = true;
                GameEventController.instance.woPanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerTouching = true;
            if (!hasBeenUsed)
            {
                exclamationMark.SetActive(true);
            }
        }       
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerTouching = false;
            exclamationMark.SetActive(false);
        }
    }

    public void Complete()
    {
        tick.SetActive(true);
        exclamationMark.SetActive(false);
    }
}