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
                if (hasInventory)
                {
                    item.image.SetActive(false);
                    playerInventory.pickUpItem(item.name);
                }
                else
                {
                    player.GetComponent<PlayerController>().Interact(this);
                    hasBeenUsed = true;
                }
            }

            // so the exclamation mark doesn't show while interacting 
            exclamationMark.SetActive(false);
        }

        //Currently not working
        //is this still not working?
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

            if (hasInventory)
            {
                inventory.SetActive(true);
                item.image.SetActive(true);
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