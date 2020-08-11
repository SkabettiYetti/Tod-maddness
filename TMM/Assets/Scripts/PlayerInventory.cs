using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
    public GameObject[] inventory = new GameObject[8];

    public GameEventController gameController;

    public void PickUpItem(string name)
    {
        switch (name)
        {
            case "keys":
                inventory[0].SetActive(true);
                gameController.GetComponent<GameEventController>().FoundKeys();
                break;
            case "toothbrush":
                inventory[1].SetActive(true);
                gameController.GetComponent<GameEventController>().FoundToothbrush();
                break;
            case "boots":
                inventory[2].SetActive(true);
                gameController.GetComponent<GameEventController>().AddClothes();
                break;
            case "tshirts":
                inventory[3].SetActive(true);
                gameController.GetComponent<GameEventController>().AddClothes();
                break;
            case "pants":
                inventory[4].SetActive(true);
                gameController.GetComponent<GameEventController>().AddClothes();
                break;
            case "toast":
                inventory[5].SetActive(true);
                gameController.GetComponent<GameEventController>().AddFood();
                break;
            case "eggs":
                inventory[6].SetActive(true);
                gameController.GetComponent<GameEventController>().AddFood();
                break;
            case "bacon":
                inventory[7].SetActive(true);
                gameController.GetComponent<GameEventController>().AddFood();
                break;
        }
    }
}
