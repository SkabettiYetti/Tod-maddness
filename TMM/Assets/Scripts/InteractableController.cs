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

    public bool hasInventory;
    public GameObject inventory;
    public Item item;
    public PlayerInventory playerInventory;

    public bool GameTime;
    public GameObject ArrowGame;


    public void Start()
    {
        instance = this;

        GameTime = false;

    }

    void Update()
    {

        if (GameTime == false)
        {
            ArrowGame.SetActive(false);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (playerTouching && !hasBeenUsed)
            {
                hasBeenUsed = true;
                if (hasInventory)
                {
                    item.image.SetActive(false);
                    playerInventory.pickUpItem(item.name);
                    Complete();
                }
                else
                {
                    player.GetComponent<PlayerController>().Interact(this);
                }
            }

            // so the exclamation mark doesn't show while interacting 
            exclamationMark.SetActive(false);
        }

        //is this still not working?,  It works it's the level finish (I think) 
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
                if (hasInventory)
                {
                    exclamationMark.SetActive(false);
                    inventory.SetActive(true);
                    item.image.SetActive(true);
                }
            }
            
        }       
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerTouching = false;
            exclamationMark.SetActive(false);
            inventory.SetActive(false);
            item.image.SetActive(false);
        }
    }

    public void Complete()
    {
        tick.SetActive(true);
        exclamationMark.SetActive(false);
    }
}