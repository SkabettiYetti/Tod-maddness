using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public GameObject[] inventory = new GameObject[8];

    public void pickUpItem(string name)
    {
        switch (name)
        {
            case "keys":
                inventory[0].SetActive(true);
                break;
            case "toothbrush":
                inventory[1].SetActive(true);
                break;
            case "boots":
                inventory[2].SetActive(true);
                break;
            case "tshirts":
                inventory[3].SetActive(true);
                break;
            case "pants":
                inventory[4].SetActive(true);
                break;
            case "toast":
                inventory[5].SetActive(true);
                break;
            case "eggs":
                inventory[6].SetActive(true);
                break;
            case "bacon":
                inventory[7].SetActive(true);
                break;
        }
    }
}
