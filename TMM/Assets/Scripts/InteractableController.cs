using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableController : MonoBehaviour
{

    public static InteractableController instance;

    private bool hasBeenUsed = false;
    private bool playerTouching = false;
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
                // so the exclamation mark doesn't show while interacting 
                exclamationMark.SetActive(false);

                hasBeenUsed = true;
                if (hasInventory)
                {
                    item.image.SetActive(false);
                    playerInventory.PickUpItem(item.name);
                    Complete();
                }
                else
                {
                    player.GetComponent<PlayerController>().Interact(this);
                }
            }

            //is this still not working?,  It works it's the level finish (I think) 
            /*
            if (playerTouching && isFinish)
            {
                PlayerController.instance.interacting = true;
                GameEventController.instance.wonPanel.SetActive(true);
                Time.timeScale = 0;
            }
            */
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerTouching = true;
            if (!hasBeenUsed)
            {
                if (hasInventory)
                {
                    inventory.SetActive(true);
                    item.image.SetActive(true);
                }
                else
                {
                    exclamationMark.SetActive(true);
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
            if (hasInventory)
            {
                inventory.SetActive(false);
                item.image.SetActive(false);
            }
        }
    }

    public void Complete()
    {
        tick.SetActive(true);
        exclamationMark.SetActive(false);
    }
}