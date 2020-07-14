using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableController : MonoBehaviour
{
    public bool hasBeenUsed = false;
    public bool playerTouching = false;

    public GameObject player;
    public GameObject tick;

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
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerTouching = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerTouching = false;
        }
    }

    public void Complete()
    {
        tick.SetActive(true);
    }
}